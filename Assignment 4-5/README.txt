README.txt

HughesBankingSystem Visual Studio Solution

By: Christian Hughes - 04/08/15
Course: CIS 501 - David Schmidt

NOTES:


-There is only one known issue: If a customer account is closed, it will only withdraw the funds from the bank account that is given. If the customer owns more than one account, then the Hughes Bank will keep the money in the other accounts ;). This may be unfortunate for the customer, but it still fufills the use case scenario as provided ("A customer with a bank-account number visits a teller and closes the customer account.").

-There is error checking everywhere, and I am fairly certain that it won't ever crash. Don't quote me on that though. The program is very good at figuring out if the input is bad, and will display an error message accordingly. Make sure that the input does not include dollar signs or commas, it will see that as invalid. Ints and doubles only please.

-The threads also do their job of keeping thier distance from each other: it's impossible for any combination of the assemblies to accsess the same item in the database at the same time.

-I created a second customer (Bill Gates) for the purpose of testing. A message box will appear similar to D. Trump. His customer number is 002, and he has an account, 101, with $10,000.