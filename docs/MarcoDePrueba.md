Con el objetivo de probar las funcionalidades de mi código y verificar que se comportan correctamente según lo esperado, es necesario escribir test unitarios. Cada unidad de dichos test, constituirá el código que quiero probar y esta unidad debe ser lo más pequeña posible. Los test unitarios son automáticos, y los puedo realizar a través de un marco de prueba, que el empleo del framework .NET en mi proyecto me permite ejecutar estos test utilizando para ello, el comando ```dotnet test ```. De esta forma, la ejecución en primer lugar me encuentra los test unitarios que he escrito, posteriormente ejecuta cada uno de ellos y finalmente me brinda un reporte mostrando si los test pasaron la prueba o no.

Utilizando el lenguaje de programación C# con el framework .NET en mi proyecto, puedo decidir qué marco de prueba utilizar para realizar los test unitarios y entre los más utilizados y nombrados se encuentran: xUnit, MSTest y NUnit. Teniendo en cuenta la siguiente [documentación](https://docs.microsoft.com/en-us/dotnet/core/testing/), he realizado una tabla resumen con los 3 marcos de prueba antes mencionados:

| Criterio | MSTest | NUnit |xUniT | Comentarios|
|----------|--------|-------|------|------------|
|Atributos que emplea para marcar el método de prueba|[TestMethod]|[Test]|[Fact]|-|
|API para probar el método |Assert.AreEqual|Assert.AreEqual|Assert.Equal|Misma API para probar el método implementado, varía el método empleado por la clase Assert.|
|Constructor|-|[SetUp]|-|NUnit define de manera predeterminada un constructor, en los restantes marcos los pudiera definir, pero no es obligatorio.|
|Convención empleada para la organización y entendimiento del test|-Arrange -Act -Assert|-Arrange -Act -Assert|-Arrange -Act -Assert| 

Como conclusión, para el desarrollo de mi proyecto he decidido emplear el marco de prueba xUnit no solo por su simplicidad de uso, sino que también xUnit es una herramienta gratuita centrada en la comunidad de código abierto de .Net. y una carcateristica muy útil sobre todo si el proyecto a desarrollar es una Web API .Net Core, es, que combinado con la librería Moq, crean una plataforma muy flexible, extensible y muy potente para implementar pruebas automatizadas.




