\# PruebaMRP - .NET 8 Web API



API REST desarrollada en .NET 8 que implementa un CRUD completo de productos, contenedorizada con Docker, respaldada por pruebas unitarias, infraestructura como código y automatización con CI/CD.



\---



\## 1. Requisitos Previos

\* .NET 8 SDK

\* Docker Desktop

\* Terraform (opcional)



\---



\## 2. Cómo Ejecutar Localmente



Para correr la aplicación de manera nativa sin usar Docker:



1\. Clona el repositorio y entra a la carpeta del proyecto:

&#x20;  ```cmd

&#x20;  git clone \[https://github.com/Alejandro-Anza/PruebaMRP.git](https://github.com/Alejandro-Anza/PruebaMRP.git)

&#x20;  cd PruebaMRP

Restaura las dependencias y compila la solución:



DOS

dotnet restore

dotnet build

Ejecuta el proyecto de la API:



DOS

cd src/PruebaMRP

dotnet run

Abre tu navegador e ingresa a http://localhost:5000 o la ruta asignada.



3\. Cómo Construir la Imagen de Docker

El proyecto incluye un Dockerfile con compilación multi-etapa.



Construir la imagen Docker:



DOS

docker build -t product-api .

Ejecutar el contenedor (mapeando el puerto 8081 del host al 8080 del contenedor):



DOS

docker run -d -p 8081:8080 --name product-api-container product-api

Verificar en el navegador ingresando a: http://localhost:8081/swagger



4\. Cómo Ejecutar Terraform

Los archivos de configuración de infraestructura se encuentran en la carpeta infra/.



Navega a la carpeta de infraestructura:



DOS

cd infra

Inicializa los proveedores de Terraform:



DOS

terraform init

Revisa el plan de ejecución:



DOS

terraform plan

Aplica la configuración:



DOS

terraform apply

5\. Ejemplos de Uso (cURL)

Obtener todos los productos (GET):



DOS

curl -X GET "http://localhost:8081/api/products" -H "accept: application/json"

Crear un nuevo producto (POST):



DOS

curl -X POST "http://localhost:8081/api/products" -H "Content-Type: application/json" -d "{\\"name\\": \\"Teclado Mecanico\\", \\"price\\": 1200.50, \\"stock\\": 15}"

Obtener un producto por ID (GET):



DOS

curl -X GET "http://localhost:8081/api/products/3fa85f64-5717-4562-b3fc-2c963f66afa6" -H "accept: application/json"

Actualizar un producto (PUT):



DOS

curl -X PUT "http://localhost:8081/api/products/3fa85f64-5717-4562-b3fc-2c963f66afa6" -H "Content-Type: application/json" -d "{\\"id\\": \\"3fa85f64-5717-4562-b3fc-2c963f66afa6\\", \\"name\\": \\"Teclado RGB Modificado\\", \\"price\\": 1400.00, \\"stock\\": 10}"

Eliminar un producto (DELETE):



DOS

curl -X DELETE "http://localhost:8081/api/products/3fa85f64-5717-4562-b3fc-2c963f66afa6" -H "accept: application/json"





