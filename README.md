# Lupa NH API

Lupa NH é uma aplicação para mapeamento de falta de asfaltamento, saneamento básico e iluminação pública no bairro do Novo Horizonte em Macapá.

Projeto idealizado pelo Walter Teixeira Lima Junior
https://seer.uscs.edu.br/index.php/revista_comunicacao_inovacao/article/view/5030

![print](https://imglupa.blob.core.windows.net/img/home.jpeg)


## Informações da base de dados

```
 MongoDD scripts
 
 
use LupaNHDb

db.createCollection('TrashIssue')
db.createCollection('SewerIssue')
db.createCollection('WaterIssue')
db.createCollection('AsphaltIssue')

#valores ficticios 

db.LightIssue.insertMany([{'HasLightPole': true,'Long':-31.087416,'Lat':10.032025,'IsItWorking': false,'Description': '...'}

db.TrashIssue.insertMany([{'HasWasteCollection': true,'Long': -21.087416,'Lat':10.032025,'HowOften': 0,'Description': '...'}])

db.SewerIssue.insertMany([{'HasSanitation': true,'Long': -21.087416,'Lat':10.032025,'HasCesspool': false,'Description': '...'}])

db.AsphaltIssue.insertMany([{'EndLong': -31.09092,'Long': -21.087416,'Lat':40.032025, 'EndLat':11.032025,'Description': '...'}])

db.WaterIssue.insertMany([{'HasPipedWater': true,'HasOftenWaterLack': 1,'Long':-11.087416,'Lat':20.032025,'HasBorehole': false,'KindofBorehole': 1,'Description': '...'}])


```


## Autores / Authors

* **Wellington Ferreira** - [Wellingtonp1](https://github.com/wellingtonp1)


## Acknowledgments

* Este é um trabalho volutário
* Open source 
* Contribuições são bem-vindas!

* It's a volunteer work in order to support local communities 
* It's an open source project
* Contributions are welcome!
