# Design Patterns With .Net 7

## Observer Design Pattern
-	Behavioral (Davranışsal) bir pattern 
-	Gözlemci, izleyici, gözetmen anlamına gelir. X nesnesinin y özelliğinde bir manipülasyon yapıldığında x nesnesini izleyen-gözleyen diğer a,b,c vb. gibi nesnelere yeni state’i bildiren tasarım desenidir.<br>
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
Örnek olarak;<br>
Bir bankadan para çekilmesi işlemi için ara bir Proxy oluşturularak bankadaki işlemleri yalnızca login olan kullanıcıların yapması sağlanabilir.<br>
Loglama yapılırken bir ara Proxy oluşturularak 5 logdan daha az log geldiğinde yazdırmayıp toplu log bastırma işlemi yapılabilir.

## Adapter Design Pattern
- Structural bir design pattern. <br>
Örneğin bankadan bir para çekme yatırma işlemimiz olsun. Bu işlem için bazı bankalardan xml dönüyor bazılarından json dönüyor. Biz bu işlem için bir adaptör oluşturarak gelen veriye göre işlem yapılmasını sağlayabiliriz.

## Strategy Design Pattern
-	Behavioral (Davranışsal) bir pattern
-	Nesnenin farklı durumlarına veya gereksinimlerine uyacak şekilde değişiklikleri runtime’da yapmayı sağlar. 
-	Uygulama seviyesinde değişiklikler yapılmadan istenilen değişikliğin elde edilmesini sağlar. 
-	Genişleyen ve gelişen bir uygulama yapısı içinde esnek ve ölçeklenebilir bir tasarım sağlamak için önemlidir.<br>
Örnek olarak ;<br>
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
- C#'da kendiliğinden var olan StringBuilder metodu gibi düşünebiliriz. Orada append yapabiliyoruz. Bu design pattern sayesinde biz de dilediğimiz gibi sonuna başına ekleme yapabilir ve özelleştirmeler yapabiliriz.
<br>
 Örnek olarak oluşturulan bir kullanıcının şirket içi çalışansa mail adresinin sonuna @company.com.tr uzantısı ekle, değilse aynen bırak gibi bir işlem yapılabilir. 

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
<br>Ek Not:<hr>
.Net üzerinde MediaR kütüphanesi bizim için bu işlemi yapar. Yoğunlukla CQRS ile birlikte kullanılır. Bu yapı bize command ve querylerin ayrıştırılmasını sağlar. Bir diğer deyişle manipüle edilen datayla sadece get sorgusu atılan sorguların ayrımını sağlar. Bu da epey performans sağlar. Çünkü bir sisteme günde 10bin get isteği geliyorsa 50 adet post isteği geliyorsa bunları birbirinden ayırarak yönetmek epey performansı arttıracaktır.
<br>Örnek kod için şu projeye bakabilirsiniz: <br>
https://github.com/yigittanyel/Onion-Architecture-CQRS-Clean-Architecture-

## CQRS Design Pattern (Command and Query Responsibility Segregation)

- Bir uygulamada komut ve sorgu işlemlerinin sorumluluklarını ayrı ayrı ele alarak uygulamanın performansını ve ölçeklenebilirliğini artırmak için kullanılan bir tasarım desenidir. Bu desen, uygulamanın veritabanında işlem yapan iş mantığının daha iyi ölçeklenmesine ve performansının artırılmasına olanak sağlar.
- Daha basitçe ifade etmek gerekirse sadece okumak istediğimiz veriler ve manipüle edilen verilerin birbirinden ayrıştırılması prensibine dayanır. Örnek olarak bir sistemde günde 5000 adet get sorgusu atılırken 50 adet post/update sorgusu atılan bir senaryoda bu iki kısmı birbirinden ayrı sistemler olarak tasarlamak, hatta daha yoğun sistemlerde bu verilerin veri tabanlarını bile ayrı tutmak mantıklı olabilir. İşte bu durumlarda başvurulması gereken pattern CQRS'dir.

## Repository Design Pattern

- Repository Design Pattern, veri erişim katmanını soyutlayarak, uygulama katmanındaki kodların veri kaynaklarına erişimini kolaylaştırmayı hedefler.Repository, bir tür veritabanı işlemi yapmak için kullanılan bir nesne kümesidir. Bu nesne kümesi, uygulamanın farklı katmanları arasında veri alışverişini sağlar. Repository Design Pattern, veri kaynaklarına erişmek için bir arabirim sağlar. Bu arabirim, uygulama katmanının veri kaynaklarına erişimini kolaylaştırır ve uygulama kodunun birçok yerinde tekrarlanan kodları engeller.

- Repository Design Pattern, ayrıca kodun daha iyi test edilebilmesini sağlar. Veritabanına yapılan sorguları ve işlemleri bir repository nesnesine taşıdığımızda, bu işlemleri test edebiliriz. Repository, test edilmesi gereken işlevleri soyutlamak için kullanılabilir. Bu nedenle, bir repository kullanmak, test edilebilirlik açısından önemlidir.
<br>
Özetle, Repository Design Pattern, veri kaynaklarına erişimi soyutlayarak, kod tekrarını önlemeye, veri erişimindeki değişiklikleri kolaylaştırmaya ve test edilebilirliği artırmaya yardımcı olur. <br>

.Net’de kod örneği olarak: <br>
``` 
public interface IRepository<T> where T : class
{
    T GetById(int id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Delete(T entity);
}

Bu bir interface’dir ve CRUD işlemlerini gerçekleştirmek için gereken yöntemleri içerir. Bu interface’in UrunRepository, KategoriRepository ve SiparisRepository sınıfları tarafından uygulanmasını sağlayabiliriz.
public class UrunRepository : IRepository<Urun>
{
    private readonly DbSet<Urun> _dbSet;

    public UrunRepository(DbContext dbContext)
    {
        _dbSet = dbContext.Set<Urun>();
    }

    public Urun GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public IEnumerable<Urun> GetAll()
    {
        return _dbSet.ToList();
    }

    public void Add(Urun entity)
    {
        _dbSet.Add(entity);
    }

    public void Delete(Urun entity)
    {
        _dbSet.Remove(entity);
    }
}
``` 
## UOW Design Pattern

- Unit Of Work
- Unit of Work design pattern, bir uygulamanın veritabanı işlemlerinin koordinasyonunu sağlamak için kullanılan bir yapıdır. Bu desen, bir işlem sırasında yapılacak tüm veritabanı işlemlerini tek bir iş birimi (unit of work) altında toplar ve bu iş birimini, tüm işlemler başarılı bir şekilde tamamlanana kadar işlem sonlandırılmaz.
<br>
C# için bir örnek vermek gerekirse, bir öğrenci kayıt sistemi düşünelim. Bu sisteme yeni öğrenciler eklenebilir, mevcut öğrenci bilgileri güncellenebilir veya silinebilir. Bu işlemler için ayrı ayrı veritabanı işlemleri yapmak yerine, Unit of Work desenini kullanarak tüm işlemleri tek bir iş birimi altında toplayabiliriz.
<br>
- NOT: <hr> IUnitOfWork arayüzü IDisposable arayüzünden türetiliyor, çünkü UnitOfWork sınıfı, özellikle veritabanı bağlantısı ve diğer kaynaklar gibi sınıfın dışarıya açtığı kaynakları kullanırken kaynakları temizlemek için kullanılması gereken yöntem olan Dispose() yöntemini uyguluyor.IDisposable arayüzünü uygulayan bir nesneyi kullanmayı bitirdikten sonra, kaynakları derhal temizlemek için Dispose() yöntemini çağırmak iyi bir uygulama yöntemidir. Bu şekilde, kaynaklar kapatılmadığından dolayı oluşabilecek bellek sızıntılarını önleyebiliriz. Bu nedenle, UnitOfWork sınıfı, IDisposable arayüzünü uygular ve nesnesi kullanımdan kaldırıldığında Dispose() yöntemini çağırarak kaynakları serbest bırakır. IUnitOfWork arayüzü de bu nedenle IDisposable arayüzünden türetilir.

<br>
- EXTRA : UOW - Cancellation Token İlişkisi <hr>
Unit of Work ve Cancellation Token, uygulamanın farklı yönlerinde farklı amaçlar için kullanılırlar. Ancak bazı senaryolarda birbirleriyle ilişkilendirilebilirler.

Unit of Work, bir işlem sırasında gerçekleştirilecek tüm veritabanı işlemlerini tek bir iş birimi (unit of work) altında toplar. Bu sayede tüm işlemlerin başarılı bir şekilde tamamlanması sağlanır veya işlem tamamen geri alınır. Bu desen, uygulamanın veritabanı işlemlerinin koordinasyonunu sağlamak için kullanılır.

Cancellation Token ise, bir işlemi iptal etmek için kullanılan bir yapıdır. Bu yapı sayesinde bir işlem sırasında kullanıcı iptal isteği gönderebilir veya belirli bir süreden sonra işlem otomatik olarak iptal edilebilir. Bu yapı, asenkron işlemlerde özellikle kullanışlıdır.

Unit of Work ve Cancellation Token arasında bir ilişki, özellikle uzun süren veritabanı işlemleri için kullanılabilir. Bu senaryoda, Unit of Work deseni kullanılarak tüm işlemler tek bir iş birimi altında toplanır. Daha sonra bu iş birimini, Cancellation Token ile birleştirerek işlemi iptal edebiliriz. Böylece kullanıcının işlemi iptal etmesi durumunda, tüm veritabanı işlemleri geri alınır.

``` 
public async Task DoDatabaseOperationAsync(CancellationToken cancellationToken)
{
    using (var context = new YourDatabaseContext())
    {
        using (var transaction = context.Database.BeginTransaction())
        {
            try
            {
                var unitOfWork = new UnitOfWork(context);

                // Veritabanı işlemleri burada yapılır

                await unitOfWork.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw ex;
            }
        }
    }
}

```  
<br>
Yukarıdaki kod örneğinde, DoDatabaseOperationAsync metodu veritabanı işlemlerini gerçekleştirir. Bu metot, CancellationToken ile birlikte çağrılır ve kullanıcı işlemi iptal ettiğinde veya belirli bir süre sonra işlem otomatik olarak iptal edildiğinde çalışması durdurulur. İşlemin gerçekleştirildiği UnitOfWork nesnesi, SaveChangesAsync metodu ile veritabanı değişikliklerini kaydeder.

Transaction, tüm veritabanı işlemlerini tek bir transaction altında toplar. Böylece tüm işlemlerin başarılı bir şekilde tamamlanması veya tamamen geri alınması sağlanır. Hata durumunda, transaction geri alınır ve hata fırlatılır.
