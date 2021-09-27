# ASP.NET Core Web API Project with Entity Framework & Swagger

http://localhost:7094/swagger

![1](https://user-images.githubusercontent.com/54677528/134900818-e93e70c9-a37c-40f1-a345-a4e73e263b88.PNG)

http://localhost:7094/secret
・Basic Authentication for access to “Secret” page.

![2](https://user-images.githubusercontent.com/54677528/134900920-d2b3961b-cc08-4a05-9a3f-b6fd9ab1f80b.PNG)

・The unauthorized error appears when not logged in.

![11](https://user-images.githubusercontent.com/54677528/134901174-4f099fea-0a61-40cf-a6ea-05fbcd6cb769.PNG)

http://localhost:7094/
・“Welcome” message appears when you access the home page.

![3](https://user-images.githubusercontent.com/54677528/134901106-a1e17b15-efc8-4e5e-8213-9ccc12d8db6e.PNG)

http://localhost:7094/v1/stocks
・When the post request is sent with the “name” and “amount”, if there is no other product with the same name, it is registered in the database.( Also the “name” must be up to 8 characters and alphabet characters. “Amount” must be an integer value.)

![4](https://user-images.githubusercontent.com/54677528/134901225-b41b9701-f8c2-4391-9be9-c9a6ad146e93.PNG)

http://localhost:7094/v1/stocks
・After registration, the registered information can be checked when a get request is sent to the “stocks” page.

![5](https://user-images.githubusercontent.com/54677528/134901268-df6d5f7d-632b-4d92-b0b6-6cca5dd602a8.PNG)

http://localhost:7094/v1/stokcs/{Name}
・Also can be checked with specific “name”

![12](https://user-images.githubusercontent.com/54677528/134901345-f1327334-2328-4fbd-9239-1e1cfe68cf5d.PNG)

http://localhost:7094/v1/sales
・When the “name”, “amount” and “price” values are sent as a post request, the sales are registered. Default value is "0" when no “amount” is specified.(Sales “amount” and “price” are multiplied and registered in the sales table as “totalprice”.)

![6](https://user-images.githubusercontent.com/54677528/134901374-53d4e33e-c13f-4405-9856-8369c81bd4ad.PNG)

http://localhost:7094/v1/sales
・After registration, the registered information can be checked when a get request is sent to the “sales” page.

![7](https://user-images.githubusercontent.com/54677528/134901406-21624c8f-bc6b-413b-bcbb-916c853e7418.PNG)

http://localhost:7094/stocks
・After sales registration, “amount” sold decreases from “stock”.

![8](https://user-images.githubusercontent.com/54677528/134901432-c6b68a03-ffd2-4c49-bd73-8abaf52a6a3b.PNG)

http://localhost:7094/v1/sales
・With the delete request, all “sales” data is deleted from the “sales” page.

![9](https://user-images.githubusercontent.com/54677528/134901466-15418480-5c23-4b80-a7a2-b865a8b2f47f.PNG)

http://localhost:7094/v1/stocks
・With the delete request, all “stocks” data is deleted from the “stocks” page.

![10](https://user-images.githubusercontent.com/54677528/134901486-b099a9d7-b43e-479d-85e0-09fa6d987a14.PNG)
