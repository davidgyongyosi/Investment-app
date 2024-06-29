### Specification

#### Brief description of the program

- I designed this data visualization app to display real-time information about the top 100 cryptocurrencies. The app is built on Angular 15, using Angular Materials and Tailwind CSS for the frontend, while communicating with the Asp.Net API backend. The LiveCoinWatch API is used to collect the data and it is presented in a tabular form that contains the main data of each cryptocurrency. This allows users to easily track the performance of their investments and make informed decisions. Additionally, the app allows users to calculate the value of their cryptocurrency stored in a non-crypto wallet. Administrators have access to manage user accounts and their data.

<br>
<br>

- Functions, endpoints
 - Coin endpoint, with which administrators can manage the data of certain cryptocurrencies in the database, and users can see the data in a similar way, but cannot edit it.
 - Auth endpoint, which is responsible for the authentication of the user, with which the user can log in, register, change their data, and delete their account.

<br>
<br>

- Technologies and frameworks:
 - Angular 15
 - Angular Materials
 - Tailwind CSS

<br>
<br>

#### Design draft in a few pictures

Main Page
<br>
![image](https://user-images.githubusercontent.com/43970367/235583868-ca8b23ec-d53b-43b2-8ff7-bb66322d07a2.png)

Dashboard
<br>
![image](https://user-images.githubusercontent.com/43970367/235583910-2263dd83-5de2-495b-96d3-59efb0fcd1ae.png)

Profile Page
<br>
![image](https://user-images.githubusercontent.com/43970367/235583993-66502c84-53a8-4448-befc-ca86011add0b.png)

Login and Register Modals
<br>
<img src="https://user-images.githubusercontent.com/43970367/235584040-34201cba-43ba-4d69-8b04-e3b52aa3e254.png" alt="" data-canonical-src="https://user-images.githubusercontent.com/43970367/235584040-34201cba-43ba-4d69-8b04-e3b52aa3e254.png" height="400" />
<img src="https://user-images.githubusercontent.com/43970367/235584058-9f1ede38-fd61-4eb9-88f2-ec6074a7b5f0.png" alt="" data-canonical-src="https://user-images.githubusercontent.com/43970367/235584058-9f1ede38-fd61-4eb9-88f2-ec6074a7b5f0.png" height="400" />
