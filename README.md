# OnionArchitectureApp
In this project, I aimed to create a simple onion architecture.


### What is Onion Architecture ?
Most of the traditional architectures raise fundamental issues of tight coupling and separation of concerns. Onion Architecture was introduced by Jeffrey Palermo to provide a better way to build applications in perspective of better testability, maintainability, and dependability. Onion Architecture addresses the challenges faced with 3-tier and n-tier architectures, and to provide a solution for common problems. Onion architecture layers interact to each other by using the Interfaces. C# programmers are drawn to Onion Architecture due to the dependency flows.

### What is CQRS Pattern ?
CQRS stands for Command and Query Responsibility Segregation, a pattern that separates read and update operations for a data store. Implementing CQRS in your application can maximize its performance, scalability, and security. The flexibility created by migrating to CQRS allows a system to better evolve over time and prevents update commands from causing merge conflicts at the domain level.

### What is MediatR Pattern ?
MediatR Pattern/Library is used to reduce dependencies between objects. It allows in-process messaging,but it will not allow direct communication between objects. Instead of this it forces to communicate via MediatR only, such as classes that don't have dependencies on each other, that's why they are less coupled.