# WinForm-NumberGuessName

Uygulama Hakkında

1-) Oyun en az iki kişi ile oynanmaktadır.

2-) Her oyuncu çifti bir oyun odasında yer alır. Bir odaya en fazla iki oyuncu girebilmektedir.

3-) Oyuna giriş kullanıcı adı ve parola ile gerçekleştirilir.

4-)Oyun uygulamasına ait MS SQL veritabanı script dosyası kodlar içerisinde yer almaktadır. (Kaynaklar klasörü içerisinde)

5-) Uygulama 4 adet projeden oluşmaktadır.

6-) Oyuna ait işlemler http üzerinden WCF servisi yardımıyla gerçekleştirilmektedir.

7-) Uygulamayı çalıştırdıktan sonra sisteme giriş yaparak boş bir oda olup olmadığını oda listesinden kontrol ediniz.

8-) Oda listesi altında yer alan metin kutusuna tuttuğunuz ve rakibinizin tahmin edeceği 4 basamaklı sayıyı girerek listede yer alan bir odaya bağlanınız. 

9-) Herhangi bir rakip ile eşleştiğinizde sizden rakibin sayısını tahmin etmeniz istenecek ve uygulama bu şekilde taraflardan bir tanesi rakibinin sayısını bulana kadar devam edecektir.

Oyun Nasıl Oynanıyor

1-) Rakinizin sayısını bulabilmek için sürekli tahminlerde bulunarak gelen dönüşlerden yararlanarak tahmininizi yapılandırmalısınız.

2-) Tahmininiz ile rakibin sayısı karşılaştırıldığında sırası ve değeri eşleşen her basamak için bir gülen surat, eşleşen fakat basamak sıraları uyuşmayan her sayı için bir ağlayan surat eklenmektedir.

3-) Örneğin rakibinizi tutmuş olduğu sayı 1234 olsun.

Tahmininiz 3120 ise 3,1 ve 2 sayıları eşleşir ama sıraları uyuşmadığından 3 adet ağlayan surat verecektir.

Tahmininiz 1324 ise 1 sayısı rakibin tuttuğu sayı ile hem basamak sırası hem de sayı değeri olarak eşleştiğinden 1 adet gülen surat, 3 ve 2 rakamları eşleştiği ama sıraları uyuşmadığından iki adet ağlayan surat olacaktır.


![Screenshot](http://www.ibrahimarac.com/gitimages/numbergame/numbergame-1.png)

![Screenshot](http://www.ibrahimarac.com/gitimages/numbergame/numbergame-2.png)

![Screenshot](http://www.ibrahimarac.com/gitimages/numbergame/numbergame-3.png)

![Screenshot](http://www.ibrahimarac.com/gitimages/numbergame/numbergame-4.png)

![Screenshot](http://www.ibrahimarac.com/gitimages/numbergame/numbergame-5.png)

![Screenshot](http://www.ibrahimarac.com/gitimages/numbergame/numbergame-6.png)
