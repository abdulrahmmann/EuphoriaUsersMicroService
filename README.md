# EuphoriaUsersMicroService
Euphoria Users Microservice : dedicated microservice responsible for managing user identities, profiles, and addresses within the Euphoria eCommerce System. This service handles user authentication data via Azure Authentication. Designed following Domain-Driven Design (D.D.D).

The Database Used in UsersService is Postgresql. 

Based Structure:

API → Minimal API / Controllers exposing endpoints.

Domain → Core business logic & entities and Value Objects (ApplicationUser, UserProfile).

Application → CQRS handlers using MediatR, validation data using FluentValidation and Mapping between entity and dto using Mapster.

Infrastructure → EF Core configurations & repositories & Database Migrations.
