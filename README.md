# EuphoriaUsersMicroService
Euphoria Users Microservice : dedicated microservice responsible for managing user identities, profiles, and addresses within the Euphoria eCommerce System. This service handles user authentication data via Azure Authentication. Designed following Domain-Driven Design (D.D.D).

Based Structure:

API → Minimal API / Controllers exposing endpoints.

Domain → Core business logic & entities and Value Objects (ApplicationUser, UserProfile).

Application → Business logic and handling data and implementing vertical slice architecture style: FluentValidation, DTOs, Mapping using Mapster.

Infrastructure → EF Core configurations & repositories & Database Migrations.
