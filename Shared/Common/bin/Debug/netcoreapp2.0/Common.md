## Common ##

# T:OpenCore.Common.Address

Class  models a physical street address. 



---
##### P:OpenCore.Common.Address.City





---
##### P:OpenCore.Common.Address.Country





---
##### P:OpenCore.Common.Address.Identifier





---
##### P:OpenCore.Common.Address.Latitude





---
##### P:OpenCore.Common.Address.Longitude





---
##### P:OpenCore.Common.Address.PostalCode





---
##### P:OpenCore.Common.Address.StreetAddress





---
##### P:OpenCore.Common.Address.StreetAddressAdditional





---
##### M:OpenCore.Common.Address.Validate(System.ComponentModel.DataAnnotations.ValidationContext)





---
# T:OpenCore.Common.Country

Class  models a country. 



---
##### M:OpenCore.Common.Country.#ctor(System.Int32,System.String,System.String,System.String,System.String)

 This constructor initializes the new country with the given  and  params. The  property is automatically applied as the  property of the country. 

|Name | Description |
|-----|------|
|IsoNumeric: | is the ISO 3166-1 numeric code of the country.|
|Name | Description |
|-----|------|
|Name: | is the ISO 3166-1 English short name for the country.|
|Name | Description |
|-----|------|
|CallingCode: | is the ITU-T E.123/E.164 international prefix code for the country.|
|Name | Description |
|-----|------|
|IsoThreeCode: | is the ISO 3166-1 three character code of the country.|
|Name | Description |
|-----|------|
|IsoTwoCode: | is the ISO 3166-1 two character code of the country.|


---
##### M:OpenCore.Common.Country.#ctor(System.Int32,System.Int32,System.String,System.String,System.String,System.String)

 This constructor initializes the new country with the given , , and  params. 

|Name | Description |
|-----|------|
|Identifier: | is the internal identifier of the country.|
|Name | Description |
|-----|------|
|IsoNumeric: | is the ISO 3166-1 numeric code of the country.|
|Name | Description |
|-----|------|
|Name: | is the ISO 3166-1 English short name for the country.|
|Name | Description |
|-----|------|
|CallingCode: | is the ITU-T E.123/E.164 international prefix code for the country.|
|Name | Description |
|-----|------|
|IsoThreeCode: | is the ISO 3166-1 three character code of the country.|
|Name | Description |
|-----|------|
|IsoTwoCode: | is the ISO 3166-1 two character code of the country.|


---
##### M:OpenCore.Common.Country.#ctor(System.Int32)

 This constructor initializes the new country with only the  when quick constructs are required for entities that will be referenced in a database in a later action. 

|Name | Description |
|-----|------|
|Identifier: | is the internal identifier of the country.|


---
##### P:OpenCore.Common.Country.CallingCode





---
##### P:OpenCore.Common.Country.Identifier





---
##### P:OpenCore.Common.Country.IsoThreeCode





---
##### P:OpenCore.Common.Country.IsoTwoCode





---
##### P:OpenCore.Common.Country.IsoNumeric





---
##### P:OpenCore.Common.Country.Name





---
# T:OpenCore.Common.TimeZone

 Class  models the complexities of a time zone. 



---
##### P:OpenCore.Common.TimeZone.Abbreviation





---
##### P:OpenCore.Common.TimeZone.Canonical

_C# code_

```c#
e.g. America/Chicago
```





---
##### P:OpenCore.Common.TimeZone.Identifier





---
##### P:OpenCore.Common.TimeZone.MilitaryTimeZone





---


