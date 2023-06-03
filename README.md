
# Clorse

An online course sales platform similar to udemy with microservice architecture

## Requirements
.NET Core 3.1 Runtime
.NET Core 7
Docker

## Run Locally

Clone the project

```bash
  git clone https://github.com/berkcanarslan/clorse-microservices.git
```

Go to the project directory


## Docker Configuration

### CatalogDB:
MongoDB container for the CatalogAPI with the 27017:27017 Ports

### IdentityDB:
SQL container for the IdentityServer with the 1433:1433 Ports

Password=Password12* (can be configured in appsettings)

#### Tip: You can use portainer for docker management.
