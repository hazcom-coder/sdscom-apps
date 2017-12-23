# sdscom-apps

This repo will contain a Safety Data Sheet authoring program that is compatible with SDSComXML. A manin feature of the Authoring program will be the ability to import and export documents via an API.

The Applications will be writtern in .net core 2.0+, which is an open source, cross platform development langauge used globally by many enterprises. The application is written in the MVC style using the ,net Razor engine

The Applications use jQuery and bootstrap to handle communication with the server and ui styling.

The Application is attached to a PostgreSQL database and uses SimpleStack.OrmnLite as its data layer

There are a number of other nuget packages involved, but since things are evolving steadily, no others will be listed until they are determined to be baked into project.

If you are interested in participating please contact the owner.

The project was started in November 2017 and is still in it's infancy, There is no time table yet for even a basic alpha version.

Some basic decisions already made:

- SDSComXML schema will be used as basis for authoring, apps will need to be updated as schema evolves. Only latest version supported
- UI must be translatable 
- Application Security will used internally managed data from the database, permissions will be basic at this point
- EUPHRAC phrase library will be incorporated for English and German, other languages will be community provided

That is all for now
