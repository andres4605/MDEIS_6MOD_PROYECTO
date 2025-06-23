📁 API/ Presentación
Contiene:
•	Controllers → Expone los endpoints (REST).
•	Program.cs → Bootstrap y configuración.
✔️ Esta capa usa Application y no accede directamente a Domain, lo cual está alineado con DDD.

📁 Application/ 
Esta capa:
•	No contiene lógica de negocio compleja.
•	Contiene Commands y Queries, con sus respectivos Handlers.
•	Usa interfaces (como IOrderRepository, IEventBus) para interactuar con Domain.
✔️ Esta es la capa de orquestación, responsable de coordinar tareas del dominio, cumpliendo el principio de separación de capas en DDD.

📁 Domain/
Contiene los elementos centrales del dominio:
•	Entities → Ej: Order, OrderItem (con lógica de negocio dentro).
•	Events → Eventos de dominio como OrderCreatedDomainEvent.
•	Repositories → Interfaces como IOrderRepository, sin implementación concreta.
✔️ Esta carpeta define el modelo del dominio, sin dependencias de infraestructura.

📁 Infrastructure/
Contiene implementaciones técnicas:
•	Data → Implementación de IOrderRepository con Entity Framework, por ejemplo.
•	Messaging → Integración con RabbitMQ.
✔️ Esta capa implementa lo que la aplicación y el dominio declaran. 

Además, está alineada al patrón arquitectonico CQRS porque separa claramente los caminos de escritura (Command) y lectura (Query).
