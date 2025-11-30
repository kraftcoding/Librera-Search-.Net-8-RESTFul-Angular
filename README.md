# Librera-Search-.Net-8-RESTFul-Angular

# Angular App and .NET 8 RESTful API with EntityFramework Core

Angular 16 CRUD example to consume Rest API (add, delete, display, modify & search data) implementing Jwt-Bearer token-based authentication. Includes Visual Studio back-end API and SQL Data model projects.

Application contains the next functionality:

- Each register has id, title, description, published status.
- We can create, retrieve, update, delete registers.
- There is a Search bar for finding registers by title.
- JWT (JSON Web Token) format used for authentication

## Token-Based Authentication with Angular 16 and .Net 8 WebAPI

Token-based authentication is a popular approach to securing web applications, providing a stateless and scalable way to verify user identities. In this implementation, we'll explore how to integrate token-based authentication using Angular 16 as the frontend framework and .Net 8 WebAPI as the backend API.

What is Token-Based Authentication?

Token-based authentication involves generating a unique token upon successful user authentication, which is then passed with each subsequent request to verify the user's identity. This approach eliminates the need for server-side session storage, making it ideal for modern web applications.

Key Components:

- .Net 8 WebAPI: Handles token generation and validation
- Angular 16: Manages user authentication and includes the token in requests
- JWT (JSON Web Token): The token format used for authentication

This implementation provides a secure and efficient way to authenticate users, allowing for seamless interaction between the frontend and backend.

## Additional info

Disable same origin policy in Chrome

cd "C:\Program Files\Google\Chrome\Application"

chrome.exe --disable-web-security --user-data-dir="C:\Program Files\Google\Chrome\Application"

Install NVM (exe to download)

https://github.com/coreybutler/nvm-windows/releases

Install Node.js (exe to download)

https://nodejs.org/dist/

https://nodejs.org/en/about/previous-releases

nvm install node

nvm use 25.2.1

nvm install --lts

nvm install <version> # like: 14.17.6

nvm -v

nvm off

nvm on

nvm install lts 64

nvm use newest

nvm list

nvm use

node --version

To install and use a especific version of Node:

nvm install 22.21.1

nvm use 22.21.1

nvm ls

"Allow CORS: Access-Control-Allow-Origin" extendion might be needed to test in local environment

Otherwise, disable same origin policy in Chrome:

cd "C:\Program Files\Google\Chrome\Application"

chrome.exe --disable-web-security --user-data-dir="C:\Program Files\Google\Chrome\Application"

To use a specific version of Node:

nvm install 22.21.1

nvm use 22.21.1

nvm ls
