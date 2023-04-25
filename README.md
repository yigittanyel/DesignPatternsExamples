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
- Creational Design Pattern
-	Objeden yalnızca bir kere yaratıldığından emin olunur.  
-	Global erişim olur.
-	Her requestte yeniden oluşturulmaktan ziyade bir kez oluşturulur ve lifetime boyunca bu oluşturulan nesne kullanılır.
<br>
Bu yapıda kullanıcıya kendi başına bir nesne yaratma izni verilmez. Kullanıcı bizden sadece nesne talep edebilir ve bizden nesne talep ettiğinde de biz ona her defasında bellekte var olan nesneyi veririz.

## Builder Design Pattern
- Creational bir pattern.
- Karmaşık nesne oluşturma işlemlerini daha anlaşılır ve modüler hale getirmeye yardımcı olan bir tasarım kalıbıdır.
- Örnek olarak oluşturulan bir kullanıcının şirket içi çalışansa mail adresinin sonuna @company.com.tr uzantısı ekle, değilse aynen bırak gibi bir işlem yapılabilir. 
- C#'da kendiliğinden var olan StringBuilder metodu gibi düşünebiliriz. Orada append yapabiliyoruz. Bu design pattern sayesinde biz de dilediğimiz gibi sonuna başına ekleme yapabilir ve özelleştirmeler yapabiliriz.

## MVC Design Pattern
- Architectural Design Pattern
- Veri ve gösterimin soyutlanması esasına dayanır.Böylece veriler(model) ve ui(view) birbirini etkilemeden controller adı verilen ara bileşenle çözümlenir. <br>
NOT: ASP.Net MVC Framework ile karıştırılmamalıdır. Microsoft henüz yeni kurulduğunda bile bu tasarım deseni mevcuttu. 

## Bridge Design Pattern
- Structural Design Pattern
- Bir nesnenin soyutlanmasını ve onunla ilgili gerçekleştirme detaylarını ayırarak esneklik ve genişletilebilirlik sağlar.

## Mediator Design Pattern
- Behavioral Design Pattern
- Nesneler arası iletişimi kolaylaştırmak ve düzenlemek için kullanılır. Bu desen bir nesnenin diğer nesnelerle doğrudan iletişim kurmasının yerine aracı bir nesne aracılığıyla iletişim kurulmasını sağlar.<br>
Uçakları kontrol eden kule gibi düşünebiliriz. Uçaklar kule ile iletişime geçer, kule de onlara ilgili cevabı döner. Bu örnek üzerinde mediator bizim için kuledir.
<br>Ek Not:
.Net üzerinde MediaR kütüphanesi bizim için bu işlemi yapar. Yoğunlukla CQRS ile birlikte kullanılır. Bu yapı bize command ve querylerin ayrıştırılmasını sağlar. Bir diğer deyişle manipüle edilen datayla sadece get sorgusu atılan sorguların ayrımını sağlar. Bu da epey performans sağlar. Çünkü bir sisteme günde 10bin get isteği geliyorsa 50 adet post isteği geliyorsa bunları birbirinden ayırarak yönetmek epey performansı arttıracaktır.
<br>Örnek kod için şu projeye bakabilirsiniz: <br>
https://github.com/yigittanyel/Onion-Architecture-CQRS-Clean-Architecture-

