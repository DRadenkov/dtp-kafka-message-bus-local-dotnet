using com.uefa.avro.keys.fdf.matchevent;
using com.uefa.avro.values.fdf.matchevent;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using Type = com.uefa.avro.values.fdf.matchevent.Type;

namespace UEFAMessagebusTester.Kafka
{
    class KafkaAvroProducer
    {
        private string bootstrapServers = "54.76.106.161:9092,54.246.230.212:9092,54.154.136.88:9092";
        private string schemaRegistryUrl = "http://34.245.6.186:8081";
        private string topicName = "MatchEvent";

        private Producer<MatchEventKey, MatchEvent> producer = null;

        public void init() {
            try
            {

                var producerConfig = new Dictionary<string, object>
                {
                    { "bootstrap.servers", bootstrapServers },
                    { "socket.blocking.max.ms", 1 },
                    { "acks", "all" },
                    { "message.send.max.retries", 0 },
                    { "linger.ms", 1 },
                   
                   
                    // Note: you can specify more than one schema registry url using the
                    // schema.registry.url property for redundancy (comma separated list). 
                    // The property name is not plural to follow the convention set by
                    // the Java implementation.
                    { "schema.registry.url", schemaRegistryUrl },
                    // optional schema registry client properties:
                    { "schema.registry.connection.timeout.ms", 5000 },
                    { "schema.registry.max.cached.schemas", 2000 },
                    // optional avro serializer properties:
                   //{ "avro.serializer.buffer.bytes", 50 },
                    //{ "avro.serializer.auto.register.schemas", true }
                };

                producer = new Producer<MatchEventKey, MatchEvent>(producerConfig, new AvroSerializer<MatchEventKey>(), new AvroSerializer<MatchEvent>());
                
                Console.WriteLine("Producer builded!");
            }
            catch (Exception e) {
                Console.WriteLine("Error while creating producer" , e);
            }
            
           
        }

        public bool isNullProducer() {
            return producer == null;
        }

        public Boolean sendMessage(MainForm form)
        {
            try
            {
                MatchEventKey key = new MatchEventKey();
                key.MatchId = 1;
                List<Attributes> attributes = new List<Attributes>();
                attributes.Add(Attributes.Blocked);
                attributes.Add(Attributes.BigChance);

                MatchEvent value = new MatchEvent();
                value.Operation = Operation.Add;
                value.EventId = 12345;
                value.MatchId = 1;
                value.PhaseId = Phase.a2;
                value.Type = Type.Assist;
                value.Attributes = attributes;
                value.TeamFromId = 564;
                value.TeamToId = 458;
                value.PlayerFromId = 10756;
                value.PlayerToId = 15783;
                value.TimeUTC = "2018-09-12T06:55:59.919";
                value.Minute = 45;
                value.Second = 13;
                value.InjuryMinute = 44;
                value.PositionX = 0.541211f;
                value.PositionY = 0.342281f;
                value.GoalGatePositionX = 0.144251f;
                value.GoalGatePositionY = 0.264641f;
                value.GoalGatePositionZ = 0.0f;
                Console.WriteLine(value.ToString());


                Message<MatchEventKey, MatchEvent> message = new Message<MatchEventKey, MatchEvent>();
                message.Key = key;
                message.Value = value;
                producer.ProduceAsync(topicName, message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while sending message to topic", e);
                return false;
            }

            return true;
        }
        
    }
}
