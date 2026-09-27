# Trabajo Práctico: Librería El Papiro - UTN FRSN

**Asignatura:** Paradigmas de Programación  
**Docente:** Ing. David CECCHI  
**Institución:** Universidad Tecnológica Nacional – Facultad Regional San Nicolás  
**Modalidad:** Trabajo Grupal (2 Integrantes)  

---

## ?? Modalidad y Condiciones de Evaluación

* **Modalidad:** Trabajo Grupal (2 integrantes).
* **Objetivo:** Evaluar los conocimientos adquiridos en la Unidad Temática 4, integrando los saberes de las unidades anteriores.
* **Calificación:** La calificación máxima permitida en esta instancia solo otorga la **Regularización**. Los alumnos que aspiren a la **Promoción Directa** deberán realizar la defensa oral del trabajo práctico en la fecha que oportunamente comunique la cátedra.
* **Formato de Entrega:** Proyecto completo comprimido en un único archivo .zip o .rar.
* **Recepción:** El único medio válido para la entrega es la plataforma **CVG**. No se aceptan entregas por e-mail.

---

## ??? Consignas Generales

1. Desarrollar una aplicación de escritorio **Windows Forms** en C# utilizando **Visual Studio 2026**.
2. Diseñar un único formulario que permita realizar las operaciones **CRUD** sobre la tabla requerida.
3. Desarrollar una clase con sus propiedades encapsuladas y dos constructores que represente la entidad correspondiente.
4. Desarrollar dos repositorios:
   * Un repositorio funcional (SQL Server).
   * Un repositorio con sus operaciones sin implementar (Mock / Stub).
5. Desarrollar una **Interfaz** que sea implementada por ambos repositorios.
6. Implementar **Inyección de Dependencias**.
7. Implementar validaciones en la capa UI separadas en dos funciones específicas:
   * ValidacionFormulario: sobre la integridad y formato de los datos ingresados.
   * ValidacionReglas: sobre las reglas de negocio específicas.
   * Mantener la capa de repositorios únicamente con sus responsabilidades de acceso a datos.
8. Aplicar el tratamiento adecuado sobre operaciones asíncronas nativas y propias (sync / wait).
9. Implementar manejo explícito de excepciones mediante bloques 	ry-catch donde corresponda.
10. El proyecto debe compilar sin errores ni advertencias críticas.

---

## ?? Consignas Particulares

### 1. Base de Datos
* En **SQL Server Management Studio**, crear la base de datos denominada TPLibreria.
* Ejecutar el script SQLLibreria.sql adjunto en la plataforma CVG para crear la estructura de tablas e insertar los datos iniciales.

### 2. Diseño y Funcionalidad de la Interfaz (UI)

* **Formulario (rmTPLibreria):**
  * Presentado centrado en pantalla.
  * Título de ventana: Librería El Papiro.

* **Botones:**
  * tnRegistrar
  * tnCancelar

* **Grilla de Datos (DataGridView):**
  * Modo **solo lectura** (sin edición directa, adición o eliminación desde la grilla).
  * Campo IdLibro oculto.
  * Títulos de columnas presentados con nombres amigables y formateo adecuado según tipo de dato.

* **Campos del Formulario y Validaciones:**
  * **ISBN (TextBox):** 13 dígitos numéricos, mayor a 0 y de valor único por libro.
  * **Título (TextBox):** Requerido (nunca vacío), respetando longitud máxima.
  * **Autor (TextBox):** Requerido (nunca vacío), respetando longitud máxima.
  * **Editorial (ComboBox):** Selección única, primera opción por defecto (Prentice Hall, Manning, OReilly Media, Andrew Hunt).
  * **Fecha de Publicación (DateTimePicker):** No puede ser posterior a la fecha actual.
  * **Categoría (RadioButton):** Opciones: Programación, Análisis Numérico, Sistemas.
  * **Precio de Venta (TextBox):** Mayor a 0 y no inferior al mínimo estipulado según categoría:
    * *Programación:* .000
    * *Desarrollo Web / Análisis Numérico:* .000
    * *Bases de Datos / Sistemas:* .000
  * **Disponible (CheckBox):** Indica disponibilidad de stock.
