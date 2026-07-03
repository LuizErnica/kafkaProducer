# Kafka Producer (.NET)

> A simple .NET application demonstrating how to produce messages to an Apache Kafka topic using a Kafka Producer.

## 📚 About the Project

This project is a practical example of implementing a **Kafka Producer** using **.NET** and **C#**.

Its primary goal is to demonstrate how to connect to an Apache Kafka broker, publish messages to a topic, and understand the fundamentals of event-driven communication.

This repository is intended for educational purposes and serves as a starting point for developers learning Apache Kafka integration with .NET applications.

---

## 🚀 Technologies

- .NET
- C#
- Apache Kafka
- Docker
- Confluent.Kafka (.NET Client)

---

## ✨ Features

- Connect to an Apache Kafka broker
- Publish messages to Kafka topics
- Simple producer implementation
- Configurable broker address
- Educational and easy-to-understand code
- Docker-based Kafka setup

---

## 📂 Project Structure

```text
KafkaProducer
│
├── Program.cs
├── appsettings.json
├── Properties/
├── README.md
└── KafkaProducer.csproj
```

> *The structure may evolve as new features are added.*

---

## 🎯 Objectives

- Learn the fundamentals of Apache Kafka
- Understand the Producer role in Kafka
- Publish messages using .NET
- Learn how to configure Kafka clients
- Practice event-driven application development

---

## ▶️ Getting Started

### Clone the repository

```bash
git clone https://github.com/LuizErnica/kafkaProducer.git
```

### Navigate to the project

```bash
cd kafkaProducer
```

### Restore dependencies

```bash
dotnet restore
```

### Run the application

```bash
dotnet run
```

---

# 🐳 Running Kafka with Docker

Kafka provides an official Docker image that can be used for local development.

**Kafka Docker Image Usage Guide**

https://github.com/apache/kafka/blob/trunk/docker/examples/README.md

### Start a Kafka broker

```bash
docker run -d --name broker apache/kafka:latest
```

### Access the container

```bash
docker exec --workdir /opt/kafka/bin/ -it broker sh
```

### Create a topic

```bash
./kafka-topics.sh \
  --bootstrap-server localhost:9092 \
  --create \
  --topic test-topic
```

### Remove the broker

```bash
docker rm -f broker
```

---

## 🌐 Allow External Clients to Connect

Run Kafka exposing port **9092**:

```bash
docker run -d -p 9092:9092 --name broker apache/kafka:latest
```

Verify that the port is listening (Windows):

```powershell
netstat -an | findstr 9092
```

---

## 📖 Concepts Covered

- Apache Kafka
- Kafka Producer
- Topics
- Brokers
- Message Publishing
- Event-Driven Architecture
- Docker
- Asynchronous Programming
- Producer Configuration

---

## 💡 Learning Outcomes

By exploring this project, you will learn how to:

- Configure a Kafka Producer in .NET
- Connect to a Kafka broker
- Create and use Kafka topics
- Send messages asynchronously
- Run Kafka locally with Docker
- Understand the basics of event-driven systems

---

## 📚 References

- Apache Kafka Documentation
- Confluent.Kafka .NET Client
- Microsoft Learn — .NET
- Docker Documentation

---

## 👨‍💻 Author

**Luiz Henrique Érnica**

GitHub: https://github.com/LuizErnica

---

## 📄 License

This project was created for educational and learning purposes.
