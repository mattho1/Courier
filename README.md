# Courier Application

Application supporting the work of couriers. In application are three types of users: administrator (can manage users and boxes) , courier (can manage boxes) and client (can see your boxes). The app stores date in XML files. 

Application requires adding file user.xml. This file must contain at least one user. 

Example file:

&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;Users xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"&gt;
  &lt;users&gt;
    &lt;User&gt;
      &lt;id&gt;1&lt;/id&gt;
      &lt;name&gt;Mateusz&lt;/name&gt;
      &lt;surname&gt;Kowalski&lt;/surname&gt;
      &lt;street&gt;Długa&lt;/street&gt;
      &lt;login&gt;mat&lt;/login&gt;
      &lt;password&gt;mat&lt;/password&gt;
      &lt;role&gt;Administrator&lt;/role&gt;
    &lt;/User&gt;
  &lt;/users&gt;
&lt;/Users&gt;
