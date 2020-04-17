# LupaNHAPI

## Informações da base de dados

'''
 
use LupaNHDb

db.createCollection('TrashIssue')
db.createCollection('SewerIssue')
db.createCollection('WaterIssue')

db.LightIssue.insertMany([{'HasLightPole': true,'Long':-31.087416,'Lat':10.032025,'IsItWorking': false,'Description': '...'}

db.TrashIssue.insertMany([{'HasWasteCollection': true,'Long': -21.087416,'Lat':10.032025,'HowOften': 0,'Description': '...'}])

db.SewerIssue.insertMany([{'HasSanitation': true,'Long': -21.087416,'Lat':10.032025,'HasCesspool': false,'Description': '...'}])

db.AsphaltIssue.insertMany([{'EndLong': -31.09092,'Long': -21.087416,'Lat':40.032025, 'EndLat':11.032025,'Description': '...'}])

db.WaterIssue.insertMany([{'HasPipedWater': true,'HasOftenWaterLack': 1,'Long':-11.087416,'Lat':20.032025,'HasBorehole': false,'KindofBorehole': 1,'Description': '...'}])


'''
