# Messagebus .NET Tester

UEFA Messagebus .NET Tester is example for generating classes frm avro schemas and how exactly to use them for producing messages to Kafka topic.


##Development Requirements
Install Visual Studio to start developing
- Confluent Kafka 1.0.0-experimental-12
- Confluent Kafka Avro 1.0.0-experimental-12
- Confluent Schema Registry Avro1.0.0-experimental-12

## Getting started

Firstly you have to start with generating your new classes from the AVRO schemas which are in Resources/avro folder:


### AvroGen tool

The Avro serializer and deserializer provided by `Confluent.Kafka.Avro` can be used with the `GenericRecord` class
or with specific classes generated using the `avrogen` tool, available via Nuget (.NET Core 2.1 required):

```
dotnet tool install -g Confluent.Apache.Avro.AvroGen
``` 

Usage:

```
avrogen -s your_schema.asvc .
```


### Development Environment




### Starting the example

	Build the project with Visual Studio
	The specifc records should be resolved by the IDE
	Run the Application


## Running the service

- Connect to the brokers
- Send avro messages to the broker


