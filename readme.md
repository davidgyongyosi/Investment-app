### Specifikáció

#### Rövid leírás a programról

- Ezt az adatvizualizációs alkalmazást úgy terveztem, hogy valós idejű információkat jelenítsen meg a 100 legnépszerűbb kriptovalutáról. Az alkalmazás az Angular 15-re épül, Angular Materials és Tailwind CSS használatával a frontendhez, miközben az Asp.Net API háttérrendszerrel kommunikál. A LiveCoinWatch API az adatok összegyűjtésére szolgál, és táblázatos formában jelenik meg, amely tartalmazza az egyes kriptovaluták fő adatait. Ez lehetővé teszi a felhasználók számára, hogy könnyen nyomon kövessék befektetéseik teljesítményét, és megalapozott döntéseket hozzanak. Ezenkívül az alkalmazás lehetővé teszi a felhasználók számára, hogy kiszámítsák a nem kriptopénzes pénztárcában tárolt kriptovalutájuk értékét. Az adminisztrátorok hozzáférhetnek a felhasználói fiókok és azok adatai kezeléséhez.

<br>
<br>

- Funkciók, végpontok
  - Coin végpont, amivel az adminisztrátorok tudják kezelni egyes kriptovaluták adatait az adatbázisban, valamint a felhasználók hasonlóan lássák az adatokat, viszont ne tudják szerkeszteni.
  - Auth végpont, ami a felhasználó autentikációjáért felel, ezzel tud a felhasználó belépni, regisztrálni, adatait módosítani, valamint a fiókját törölni.

<br>
<br>

- Technológiák és keretrendszerek:
  - Angular 15
   - Angular Materials
   - Tailwind CSS

<br>
<br>

#### Design tervezet pár képben

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
