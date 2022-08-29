## :pushpin: Lógica de Negocio del Proyecto

### Actualidad
Se sabe que una dieta sana y balanceada en las mascotas, incide en que tengan una buena calidad de vida lo más larga y feliz posible. Sin embargo, hoy en día puede ser frustrante dar con un alimento que sea saludable, de calidad, asequible y apetitoso para las mascotas con la gran variedad de opciones que existen en el mercado.

### Problemas existentes
Una de las principales preocupaciones de toda persona amante de su mascota es que esté bien alimentada. Cada vez es más amplia y variada las alternativas de alimentación para las mascotas y se encuentran distintos tipos, y aunque todas pueden ser una excelente opción de alimentación, siempre hay que asegurarse que esta cubra las necesidades nutricionales.
Cada mascota es distinto. Por ejemplo, dos perros de la misma raza pueden tener un metabolismo, un pelo, nivel de energía, peso y preferencias de sabor muy diferentes. Si se alimentaran estos de la misma forma,por un lado, un perro de 5 años y 3 meses, de 3.5 kilos, con un nivel de actividad bajo y un poco de sobrepeso, y por otro, una perro de 4 años y 10 meses, en su peso ideal, 3 kg, pero con digestiones sensibles, habría un problema ya que no se estarían considerando las características concretas de cada uno, para proporcionarle aquello que realmente necesitan.

### Acerca del Sistema
_**SearchFood-ForPet**_ es un sistema de recomendación de dietas personalizadas para mascotas. Este sistema ayuda a sus usuarios a adquirir los tipos alimentos apropiados para sus mascotas entre la gran variedad ofertada. Aunque por ahora el sistema solo está orientado a realizar recomendaciones para perros, se quiere que en un futuro funcione para otras especies de mascotas.

La elección automática de la dieta por el sistema depende de una serie de variables:

En cuanto a la mascota:

- Tamaño Raza [pequeña, mediana, grande]
- Edad [cachorro, joven senior]
- Género [masculino, femenino]
- Peso (Peso de la mascota)
- Nivel de actividad [bajo, alto, medio]
- Estado de salud [alergia, refuerzo articulaciones, control peso, digestivo, esterilizado, pelo y piel, urinario]

En cuanto a la alimentación

- Tipo de Alimento (seca, húmeda, cruda, casera)
- Sabor (pollo, cerdo, verdura, atún)
- Tipo de Dieta (natural, proteínas, no cereales, no gluten)
- Tamaño de Raza (mediana, pequeña, grande)

Al adquirir recomendaciones personalizadas por el sistema de dietas personalizadas para perros, el usuario garantiza una comida que se adapta perfectamente a las necesidades nutricionales y las preferencias de su perro. De esta forma se consigue el equilibrio de proteínas, carbohidratos y las grasas que necesita.

### Sobre el funcionamiento del sistema
El sistema emplea para realizar las recomendaciones, el algoritmo KNN. Basado en el histórico de información de mascotas y alimentos, encuentra similitudes entre mascotas para generar la recomendación de dieta.El algoritmo se define con una clasificación multiclase y la clasificación final enfocada al tipo de alimento recomendado, la realiza teniendo en cuenta los k vecinos más cercanos. El valor de K estará dado porel número de clases definido. Si es par, el valor de K se elige un número impar. Dado un nuevo registro de mascota a predecir su dieta, el algoritmo calcula internamente la distancia euclidiana entre dos puntosde datos y utiliza la votación por mayoría para encontrar los vecinos más cercanos.


