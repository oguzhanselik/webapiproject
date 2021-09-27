# ASP.NET Core Web API Project with Entity Framework & Swagger

http://localhost:7094/swagger
![image](https://user-images.githubusercontent.com/54677528/134899515-2497f299-aaae-4683-af1a-74b4d0d18653.png)

http://localhost:7094/secret
・Basic Authentication for access to “Secret” page.
![image](https://user-images.githubusercontent.com/54677528/134899565-d805d1cf-4329-4088-90a1-738f200296d0.png)

・The unauthorized error appears when not logged in.
![image](https://user-images.githubusercontent.com/54677528/134899607-4745e2cb-1311-42d4-a940-ff1d6dd705f9.png)

http://localhost:7094/
・“Welcome” message appears when you access the home page.
![image](https://user-images.githubusercontent.com/54677528/134899655-1fbe372b-6ea0-4c4e-bd06-d2a276067129.png)

http://localhost:7094/v1/stocks
・When the post request is sent with the “name” and “amount”, if there is no other product with the same name, it is registered in the database.( Also the “name” must be up to 8 characters and alphabet characters. “Amount” must be an integer value.)
![image](https://user-images.githubusercontent.com/54677528/134899714-7020320c-1896-4c2a-8390-bf0bf9459f37.png)

http://localhost:7094/v1/stocks
・After registration, the registered information can be checked when a get request is sent to the “stocks” page.
![image](https://user-images.githubusercontent.com/54677528/134899757-6a326635-e1f1-4e04-8949-703d4db2184f.png)

http://localhost:7094/v1/stokcs/{Name}
・Also can be checked with specific “name” sent get request to the “stocks” page.
![image](https://user-images.githubusercontent.com/54677528/134899792-95422595-f29a-48e6-a853-5680c255180a.png)

http://localhost:7094/v1/sales
・When the “name”, “amount” and “price” values are sent as a post request, the sales are registered. Default value is "0" when no “amount” is specified.(Sales “amount” and “price” are multiplied and registered in the sales table as “totalprice”.)
![image](https://user-images.githubusercontent.com/54677528/134899836-994d14f4-462f-4be9-b08b-35cdde46d944.png)

http://localhost:7094/v1/sales
・After registration, the registered information can be checked when a get request is sent to the “sales” page.
![image](https://user-images.githubusercontent.com/54677528/134899873-7cc1178d-bc72-4992-9b48-926349e2d0c0.png)

http://localhost:7094/stocks
・After sales registration, “amount” sold decreases from “stock”.
![image](https://user-images.githubusercontent.com/54677528/134899901-31394c59-95bc-428e-beb3-aaec6da43653.png)

http://localhost:7094/v1/sales
・With the delete request, all “sales” data is deleted from the “sales” page.
![image](https://user-images.githubusercontent.com/54677528/134899938-e9a07456-befa-42e8-8711-fd5cefd43fdb.png)

http://localhost:7094/v1/stocks
・With the delete request, all “stocks” data is deleted from the “stocks” page.
![image](https://user-images.githubusercontent.com/54677528/134899965-3e9cc4ed-c105-4faf-a058-87a62b2e36e4.png)
