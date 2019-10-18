# Assignments-CphBusiness

### This is assignment 7 design by contract.

***
 we have written a small and simple console application that utilizes design by contract. 
 The program does so through the namespace **System.Diagnostics.Contracts**
 
 this allows us to use among others, the require and ensure methods. That way we have created a class that uses code contracts.
 
 ***
 So get the contracts to work, you need an application first this can be downloaded from [here](https://marketplace.visualstudio.com/items?itemName=RiSEResearchinSoftwareEngineering.CodeContractsforNET)
 
 Installing this enables your visual studio to work with code contracts.

***
All relevant contract code can be found in the Bank.cs file.
we utilize the Bank.cs file in the Program.cs file.

*** 
**In the deposit method we have included 2 contracts:**
one contract to check if the amount to be deposited is above 0.
one to ensure the balance is correct after the deposit has gone through.

**in the withdraw method, we have included 3 contracts:**
one contract to check if the amount to be withdrawn is above 0.
one contract that requires the balance to be more or equal to the withdrawn amount.
one that ensures that the correct amount is left on the balance after the withdrawel.


Group members:
Nikolai Christiansen
Nikolaj Jensen




