# Design Patterns With .Net 7

## Observer Design Pattern
-	Behavioral (Davranışsal) bir pattern 
-	Gözlemci, izleyici, gözetmen anlamına gelir. X nesnesinin y özelliğinde bir manipülasyon yapıldığında x nesnesini izleyen-gözleyen diğer a,b,c vb. gibi nesnelere yeni state’i bildiren tasarım desenidir.
Örnek olarak;<br>
Öğrenci – Okul – Veli -> Öğrenci okulu astığında okul tarafından aileye bilgi gitmesi.<br>
E-Ticaret Sistemleri -> Bir ürün stokta kalmadığı zaman stoka gelince haber verme sistemi
<br>
Subject -> Takip edilen nesne. ->  Öğrenci<br>
Concrete- >Subjecti takip eden nesne  Anne- Baba – Öğretmen<br>
Observer - > Birden fazla nesne takip ettiği zaman bu tiplere arayüz görevi görecek abstract yapı<br>

## Proxy Design Pattern
-	Structural (Yapısal) bir design pattern.
-	Bir nesneyi temsil eden bir başka nesne kullanılarak erişim olmasını sağlar. Böylece asıl nesnenin consumer tarafından direkt erişimine izin verilmez, istenilen işlemler için aracı olan nesne yani Proxy kullanılır. 
-	Kısaca, istemci ve gerçek nesne arasında bir aracı eklenerek güvenlik ve kontrol mekanizması sağlanır.<br>
Örnek olarak;
Bir bankadan para çekilmesi işlemi için ara bir Proxy oluşturularak bankadaki işlemleri yalnızca login olan kullanıcıların yapması sağlanabilir.<br>
Loglama yapılırken bir ara Proxy oluşturularak 5 logdan daha az log geldiğinde yazdırmayıp toplu log bastırma işlemi yapılabilir.

## Adapter Design Pattern
Structural bir design pattern. <br>
Örneğin bankadan bir para çekme yatırma işlemimiz olsun. Bu işlem için bazı bankalardan xml dönüyor bazılarından json dönüyor. Biz bu işlem için bir adaptör oluşturarak gelen veriye göre işlem yapılmasını sağlayabiliriz.

## Strategy Design Pattern
-	Behavioral (Davranışsal) bir pattern
-	Nesnenin farklı durumlarına veya gereksinimlerine uyacak şekilde değişiklikleri runtime’da yapmayı sağlar. 
-	Uygulama seviyesinde değişiklikler yapılmadan istenilen değişikliğin elde edilmesini sağlar. 
-	Genişleyen ve gelişen bir uygulama yapısı içinde esnek ve ölçeklenebilir bir tasarım sağlamak için önemlidir.<br>
Örnek olarak ;
Araba üretilirken özel yapım mı seri mi vs. belirtmek için sürekli gidip Uretici’nin içi değiştirilmesi gerekir. Bunun yerine strategy isimli bir ara sınıf tanımlanarak bununla üretim tipi belirtlenebilir.<br>
Futbol maçı da örnek verilebilir. Maç esnasında gol yiyince atak yapmak, öndeyken defansa çekilmek gibi farklı aksiyonlar maç devam ederken yapılır.

## Decorator Design Pattern
- Structural bir design pattern.
- Var olan bir class’a mimarisel olarak yeni nitelikler kazandırmayı sağlar. Hali hazırda var olan bir sınıfın işlevini genişletir.<br>
Örnek olarak;<br>
Geçmiş zamanlardaki ilk bilgisayarı düşünelim. Daha sonra bu bilgisayarı kalıtım alarak laptoplar geliştirildi. Bu esnada da mevcut bilgisayarın özellikleri genişletilmiş oldu. Örneğin laptopların kapağı kapanınca uyku moduna geçmesi gibi vs. <br>
Entity framework kullanırken bir kullanıcının her yeni eklenen context için bunları kaydetmenin yanı sıra bunları log olarak da basmak istediğini düşünelim. Buradaki savechanges metodu virtual olarak tanımlandığından bunu override ederek kaydı tamamlamadan önce audit logging işlemleri de eklenilerek var olan işlem genişletilmiş olur.

## Singleton Design Pattern
-	Objeden yalnızca bir kere yaratıldığından emin olunur.  
-	Global erişim olur.
-	Her requestte yeniden oluşturulmaktan ziyade bir kez oluşturulur ve lifetime boyunca bu oluşturulan nesne kullanılır.
<br>
Bu yapıda kullanıcıya kendi başına bir nesne yaratma izni verilmez. Kullanıcı bizden sadece nesne talep edebilir ve bizden nesne talep ettiğinde de biz ona her defasında bellekte var olan nesneyi veririz.
