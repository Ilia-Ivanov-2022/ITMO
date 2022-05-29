# Lab 8

## Exercise 1

BankAccount class created in the previous lab exercises has been modified. I replace the methods that generate the account number and type<br/>
with a set of constructors that can be used when creating an instance of the BankAccount class.<br/>
The default constructor is overrided, generating account numbers (in the same way as before), specifying the Checking account type and a balance equal to zero.<br/>
I also created three more constructors using different combinations of parameters:<br/>
- The first constructor will take an AccountType value. It will generate an account number, set the balance to zero, and set the account type equal to the value passed as an argument.
- The second constructor will take a value of type decimal. It will generate an account number, set Checking account type, and the balance will be set equal to the value passed as an argument.
- The third constructor will take values of type AccountType and decimal. It will generate an account number, the account type will be set equal to the value passed as an argument of AccountType, and the balance will be set equal to the value passed as an argument of decimal type
