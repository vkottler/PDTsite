# Our Website

Members: Mayank Katwal, Vaughn Kottler, Matt Quinn

## Technologies

1. **Angular JS 1.5.x**

   Eventually we will discuss the way we use Angular here.

2. **Node.js 4.4.x LTS**
  * Express, body-parser

   Node may not be the final choice as a middle layer component. For now we don't have any data to interact with so it is being used as a minimal local web server.

3. **Ubuntu Server 16.04 LTS (Prod. Env.)**

   Currently we have nothing in production.

4. **MySQL**

   Future scope, intended DBMS.

5. **NGINX or Apache**

   Eventually we will have to figure out how our application gets hosted.

## Development

###**Install Node.js (4.4.x LTS):** https://nodejs.org/en/

###**Pull the repository:**

Install git, create a new folder, open terminal at that folder,  
run `git init` and then `git remote add origin https://github.com/vkottler/PDTsite.git`  
then run `git pull origin master`. First you will need collaborator access to this repository,  
contact Vaughn Kottler for that.

###**Install dependencies:**

Since we are not including dependency sources files in the repository, you will need to retrive them using  
`npm install`. Once each, go in to the server directory and run `npm install`. **If you don't do  
that first this won't work!**

###**Run the server:**

Still inside the repository directory in your terminal, type  
`node server`. Now go to your browser and visit http://localhost:8080 and you will see the site!
