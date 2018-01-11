# WebService
- A web service is a software system designed to support interoperable machine-to-machine interaction over a network.

# What are Web Services?
- The term "web service" describes a standardized way of integrating web-based applications using the XML, SOAP, WSDL and UDDI open standards over an Internet Protocol backbone.
- XML is the data format used to contain the data and provide metadata around it, 
- SOAP is used to transfer the data, 
- WSDL is used for describing the services available 
- and UDDI lists what services are available.
## So:
- Web Services can convert your applications into Web-applications
- Web Services are published, found, and used through the Web
- Web services are application components
- Web services communicate using open protocols
- Web services are self-contained and self-describing
- Web services can be discovered using UDDI
- Web services can be used by other applications
- XML is the basis for Web services

# How Does «Web services architecture» Work? 
![Web services architecture](https://github.com/pedalv/.NetApp/blob/master/WebService/Webservices.png)
- The service provider sends a WSDL file to UDDI. 
- The service requester contacts UDDI to find out who is the provider for the data it needs, and then it contacts the service provider using the SOAP protocol. 
- The service provider validates the service request and sends structured data in an XML file, using the SOAP protocol. 
- This XML file would be validated again by the service requester using an XSD file.
## So:
- The basic Web services platform is XML + HTTP.
- The HTTP protocol is the most used Internet protocol.
- XML provides a language which can be used between different platforms and programming languages and still express complex messages and functions.

# Web services platform elements
- Web Services have three basic platform elements: SOAP, WSDL and UDDI.

# What is SOAP (Simple Object Access Protocol)?
- SOAP is used to transfer the data, 
- SOAP is a simple XML-based protocol to let applications exchange information over HTTP. Or more simple: SOAP is a protocol for accessing a Web Service.
- SOAP is a communication protocol
- SOAP is a format for sending messages
- SOAP is designed to communicate via Internet 
- SOAP is platform independent
- SOAP is language independent
- SOAP is based on XML
- SOAP is simple and extensible
- SOAP allows you to get around firewalls
- SOAP is a W3C standard

# What is WSDL (Web Services Description Language)?
- WSDL is used for describing the services available
- WSDL is an XML-based language for describing Web services and how to access them.
- WSDL is based on XML
- WSDL is used to describe Web services
- WSDL is also used to locate Web services
- WSDL is a W3C standard

# What is UDDI (Universal Description, Discovery and Integration)?
- UDDI lists what services are available
- UDDI is a directory service where businesses can register and search for Web services.
- UDDI is a directory for storing information about web services
- UDDI is a directory of web service interfaces described by WSDL
- UDDI communicates via SOAP
- UDDI is built into the Microsoft .NET platform

# History - Defining Web Services - SOAP
- In 2002, Sun released their first web service specification, JSR 101 - REST, XML -> JAX-RCP - SOAP, XML
- In 2006, Sun released JSR 224, JAX-WS 2.0 - SOAP, XML
- In 2008, Sun introduced JSR 311 -> JAX-RS - Restful, JSON
- to 2013, Sun improved with the realise of JSR 339 -> JAX-RS version 2.0
- from 2013, Apache CXF build and develop services using frontend programming APIs, like JAX-WS and JAX-RS. These services can speak a variety of protocols such as SOAP, XML/HTTP, RESTful HTTP, or CORBA and work over a variety of transports such as HTTP, JMS or JBI.

# SOAP can be implemented using technologies
- Java Busines Integration (JBI)-> services written in Java running on Java EE platforms
- Windows Communication Foundation (WCF) - > services written in C# running on .NET platforms
- Data Distribuion Service (DDS)

# Why Web Services?
- Reability, security, scalability, performance,
- Interoperability has Highest Priority
> Interoperability is a charecteristic of a product or system, whose interfaces are completely understood, to work with other products or systems, at present or future, in either implementations or access, without any restrictions.

> When all major platforms could access the Web using Web browsers, different platforms could interact. For these platforms to work together, Web applications were developed. 

> Web-applications are simple applications run on the web. These are built around the Web browser standards and can mostly be used by any browser on any platform.

- Web Services take Web-applications to the Next Level
> Using Web services, your application can publish its function or message to the rest of the world.

> Web services use XML to code and to decode data, and SOAP to transport it (using open protocols).

> With Web services, your accounting department's Win 2k server's billing system can connect with your IT supplier's UNIX server.

- Web Services have Two Types of Uses
> Reusable application components.

> Connect existing software.

# Basic concepts
## Loose coupling 
- In computing and systems design is one in which each of its components has, or makes use of, little or no knowledge of the definitions of other separate components. 
- Subareas include the coupling of classes, interfaces, data, and services.
- reference, time, format, and platform
- is transactions, queues provided by messag-oriented middleware (MOM), and interoperability standards
- Loose coupling is the opposite of tight coupling.

## messag-oriented middleware (MOM)
- (+) Store (buffer), router, or transform messages, adding and administrativ interface (monitor and tune performance)

## coupling
- refers to the interdepencies between modules.
- is the degree of interdependence between software modules, a measure of how closely connected two routines or modules are, the strength of the relationships between modules.
- can be "low" (also "loose" or "weak") or "high" (alse "tight" and "strong")
- low coupling correlates with high cohesion.
- low coupling is often a sign of a well structured computer system, good design, sepports the general gools of high rability and maintainability.
- ![Types of coupling](https://github.com/pedalv/.NetApp/blob/master/WebService/Coupling_sketches_cropped_1.svg)
					   
## cohesion
- refers to the degree to which the elements inside a module belong together.
- describe how related function within a single module are.
- hight cohesion -> Disable because software including robustnes, reliability, reusability and understanbility.
- low cohesion -> Problems because is difficulty to maintain, test, reuse, even understood.

## coupling and cohesion
- Software quality metrics of coupling and cohesion

## Connascense
- a change in one component would require the other component to be modified in order to maintain the overrall conectnes of the system.
- (+) coupling did for structur design and connascenc did for object oriented design about the complexity caused by dependency-relationships.

## Stateless
- There is no memory (state) that's maintained by the program.
- Every transaction is performed as if it was being done for the very first time by use of cache.

## Statefull, RESfull HTTP with REST
- The program has a memory (State)
- Previous transaction are remmembered and may affect the curent transaction
