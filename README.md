# RMI/RPC 
## Created with [GRPC](https://grpc.io/), in C#
### GRPC is an alternative to traditional RMI/RPC on java, GRPC works with many languages, I've chosen to write my implemtation in C#

***

I have 3 projects in the same solution.

* Student-GRPC

   this is where I create i *.proto file, which is used to auto generate the clases used with the server and client
* Client

   The client is used to send a request on startup to the server. The client recieves a string, that it splits up and prints to the console in a structered manner.
* Server

   The server consists of 3 classes, a class to accept incoming clients, a class to manage to request from the client, and a class to process the data from the *.txt and Database.
   
***


