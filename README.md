# Courier Application

Application supporting the work of couriers. In application are three types of users: administrator (can manage users and boxes) , courier (can manage boxes) and client (can see your boxes). The app stores date in XML files. 

Application requires adding file user.xml. This file must contain at least one user. 

Example file:

<?xml version="1.0" encoding="utf-8"?> <Users xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"> <users> <User> <id>1</id> <name>Mateusz</name> <surname>Kowalski</surname> <street>Długa</street> <login>mat</login> <password>mat</password> <role>Administrator</role> </User> </users> </Users>
