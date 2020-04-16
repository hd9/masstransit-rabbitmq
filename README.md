# MassTransit.RabbitMQ
A simple client-server implementation using .NET Core 3.1, MassTransit
and a RabbitMQ Docker image.

## Requirements
* Docker Desktop (Windows or Mac) or Docker Engine (Linux)
* Dotnet SDK 3.1 installed
* dotnet CLI / Visual Studio 2019

## Installing
To install the tool first clone [the source code](https://github.com/hd9/masstransit-rabbitmq) with:
```
git clone https://github.com/hd9/masstransit-rabbitmq
```

Then pull and run RabbitMQ on a local [Docker container](https://docs.docker.com/engine/reference/commandline/container/):
```
docker pull rabbitmq:latest
docker run --name r1 -it -h rh -p 5672:5672 rabbitmq
```
## Running
Open two consoles and navigate to the `ClientSvc` and `ListenerSvc` folder and
type on each: `dotnet run`

## Testing
On the `ClientSvc` window, send messages by typing test names ane emails
to confirm that the listener gets then.

## Thanks!
And don't forget to visit [blog.hildenco.com](https://blog.hildenco.com).
