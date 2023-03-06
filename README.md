# Interns

# Description
Interns is a command-line interface C# application that can downolad a file of .json, .csv or zipped .csv type from a given URL using HTTP, deserialize, parse and write it to standard output result of one of three commands: count, max-age or order.  

## Count Command

```interns.exe count <url> [ --age-gt | --age-lt age]``` - Counts number of interns and writes it to standard output. Options:
* ```count``` - counts all interns.
* ```count --age-gt <age>``` - counts interns where age is greater than <age>, where <age> is an integer.
* ```count --age-lt <age>``` - counts interns where age is smaller than <age>, where <age> is an integer.

For instance: ```interns.exe count https://piotrszymala.github.io/Interns/interns.json``` returns: ```5```.

```interns.exe count https://piotrszymala.github.io/Interns/interns.json --age-gt 22``` returns: ```2```.

## Max age Command

```interns.exe max-age <url>``` - Writes the the oldest intern's age.

For instance: ```interns.exe max-age https://piotrszymala.github.io/Interns/interns.json``` returns: ```24```

## Order command
```interns.exe order <url> [--desc]``` - Order interns by age ascending (by default) or descending. Options:
* ```order``` - default option, order ascending.
* ```order --desc``` - order descending.

For instance: ```interns.exe order https://piotrszymala.github.io/Interns/interns.json``` returns: 
```
Id: 1, Age: 20, Name: Bird Ramsey, Email: birdramsey@nimon.com, InternshipStart: 1.07.2021 00:00:00, InternshipEnd: 30.09.2021 00:00:00 
Id: 2, Age: 21, Name: Lillian Burgess, Email: lillianburgess@luxuria.com, InternshipStart: 1.07.2021 00:00:00, InternshipEnd: 30.09.2021 00:00:00 
Id: 3, Age: 22, Name: Kristie Cole, Email: kristiecole@quadeebo.com, InternshipStart: 1.07.2020 00:00:00, InternshipEnd: 30.09.2020 00:00:00 
Id: 4, Age: 23, Name: Leonor Cross, Email: leonorcross@gronk.com, InternshipStart: 1.07.2020 00:00:00, InternshipEnd: 30.09.2020 00:00:00 
Id: 5, Age: 24, Name: Marsh Mccall, Email: marshmccall@ultrimax.com, InternshipStart: 1.07.2020 00:00:00, InternshipEnd: 30.09.2020 00:00:00
```
```interns.exe order https://piotrszymala.github.io/Interns/interns.json --desc``` returns: 
```
Id: 5, Age: 24, Name: Marsh Mccall, Email: marshmccall@ultrimax.com, InternshipStart: 1.07.2020 00:00:00, InternshipEnd: 30.09.2020 00:00:00 
Id: 4, Age: 23, Name: Leonor Cross, Email: leonorcross@gronk.com, InternshipStart: 1.07.2020 00:00:00, InternshipEnd: 30.09.2020 00:00:00 
Id: 3, Age: 22, Name: Kristie Cole, Email: kristiecole@quadeebo.com, InternshipStart: 1.07.2020 00:00:00, InternshipEnd: 30.09.2020 00:00:00 
Id: 2, Age: 21, Name: Lillian Burgess, Email: lillianburgess@luxuria.com, InternshipStart: 1.07.2021 00:00:00, InternshipEnd: 30.09.2021 00:00:00 
Id: 1, Age: 20, Name: Bird Ramsey, Email: birdramsey@nimon.com, InternshipStart: 1.07.2021 00:00:00, InternshipEnd: 30.09.2021 00:00:00 
```

# Used technologies
Project is created with:
* C#
* .NET

