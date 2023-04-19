#Design Patterns With .Net 7

#Observer Design Pattern
-	Behavioral (Davranışsal) bir pattern
-	Gözlemci, izleyici, gözetmen anlamına gelir. X nesnesinin y özelliğinde bir manipülasyon yapıldığında x nesnesini izleyen-gözleyen diğer a,b,c vb. gibi nesnelere yeni state’i bildiren tasarım desenidir.
Örnek olarak;
Öğrenci – Okul – Veli -> Öğrenci okulu astığında okul tarafından aileye bilgi gitmesi.
E-Ticaret Sistemleri -> Bir ürün stokta kalmadığı zaman stoka gelince haber verme sistemi

Subject -> Takip edilen nesne. ->  Öğrenci
Concrete- >Subjecti takip eden nesne  Anne- Baba – Öğretmen
Observer - > Birden fazla nesne takip ettiği zaman bu tiplere arayüz görevi görecek abstract yapı

#Proxy Design Pattern
-	Structural (Yapısal) bir design pattern.
-	Bir nesneyi temsil eden bir başka nesne kullanılarak erişim olmasını sağlar. Böylece asıl nesnenin consumer tarafından direkt erişimine izin verilmez, istenilen işlemler için aracı olan nesne yani Proxy kullanılır. 
-	Kısaca, istemci ve gerçek nesne arasında bir aracı eklenerek güvenlik ve kontrol mekanizması sağlanır.
Örnek olarak;
Bir bankadan para çekilmesi işlemi için ara bir Proxy oluşturularak bankadaki işlemleri yalnızca login olan kullanıcıların yapması sağlanabilir.
Loglama yapılırken bir ara Proxy oluşturularak 5 logdan daha az log geldiğinde yazdırmayıp toplu log bastırma işlemi yapılabilir.

#Adapter Design Pattern
Structural bir design pattern.
Örneğin bankadan bir para çekme yatırma işlemimiz olsun. Bu işlem için bazı bankalardan xml dönüyor bazılarından json dönüyor. Biz bu işlem için bir adaptör oluşturarak gelen veriye göre işlem yapılmasını sağlayabiliriz.

#Strategy Design Pattern
-	Behavioral (Davranışsal) bir pattern
-	Nesnenin farklı durumlarına veya gereksinimlerine uyacak şekilde değişiklikleri runtime’da yapmayı sağlar. 
-	Uygulama seviyesinde değişiklikler yapılmadan istenilen değişikliğin elde edilmesini sağlar. 
-	Genişleyen ve gelişen bir uygulama yapısı içinde esnek ve ölçeklenebilir bir tasarım sağlamak için önemlidir.
Örnek olarak ;
Araba üretilirken özel yapım mı seri mi vs. belirtmek için sürekli gidip Uretici’nin içi değiştirilmesi gerekir. Bunun yerine strategy isimli bir ara sınıf tanımlanarak bununla üretim tipi belirtlenebilir.
Futbol maçı da örnek verilebilir. Maç esnasında gol yiyince atak yapmak, öndeyken defansa çekilmek gibi farklı aksiyonlar maç devam ederken yapılır.

