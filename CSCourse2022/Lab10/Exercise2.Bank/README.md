# Lab No. 10

## Exercise No. 2

Merge classes into the Banking namespace and create an assembly and a link to it. For this I do the following:
1.	Place the AccountType enumeration and the Bank, BankAccount, and BankTransaction classes in the Banking namespace and compile them into a library.
2. modify the test application. Initially, the classes will be referred to by their full name, and then you will add the using directive.
3. Compile the test application into an assembly referencing the Banking library.
Using ILDASM, make sure that the test file references the Banking DLL and does not contain the Bank and BankAccount classes themselves.
