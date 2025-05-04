# CRM AIEP - Sistema de Gestión de Clientes y Contactos

## 🧾 Descripción General

Este proyecto es una aplicación de escritorio desarrollada en **C# con Windows Forms**, diseñada para simular un sistema de gestión de clientes y sus contactos, denominado **CRM AIEP**. Se trata de un sistema funcional a nivel de interfaz gráfica con almacenamiento en memoria (listas), orientado a la práctica de validaciones, estructuras de datos, y navegación entre formularios.

## 🎯 Objetivo

Ofrecer una experiencia básica de CRM que permita:

* Registrar clientes y contactos.
* Validar datos ingresados por el usuario.
* Navegar entre distintos formularios de manera ordenada.
* Simular el acceso restringido mediante login.

## 🧩 Estructura del Proyecto

El proyecto se compone de 3 formularios principales:

### 🔐 FormularioAcceso.cs

* Validación de ingreso con usuario "admin" y clave "1234".
* En caso de éxito, se accede al formulario de cliente.

### 👤 FormularioCliente.cs

* Permite ingresar información de clientes: RUT, nombres, apellidos, ciudad, comuna, personalidad jurídica o natural, y estado civil.
* Validación de todos los campos antes de guardar.
* Opción de limpiar los campos del formulario.
* Botón para acceder al FormularioContacto.

### 📞 FormularioContacto.cs

* Registro de contactos asociados a un cliente.
* Campos similares a los del cliente con énfasis en la relación con el cliente.
* Validaciones visuales y lógicas con `ErrorProvider`.
* Población dinámica de ciudades y comunas desde arrays.

## 🧠 Lógica de Negocio

### AccesoNegocio.cs

* Valida el acceso del usuario comparando credenciales con datos predefinidos.

## 📦 Clases de Entidades

### Cliente.cs

* Representa a un cliente con propiedades como RUT, nombre, domicilio, estado civil, etc.

### Contacto.cs

* Representa a un contacto, asociado a un cliente, con información detallada de contacto.

### Acceso.cs

* Clase simple para modelar usuario y contraseña.

## 🧪 Validaciones

* Se utiliza el componente `ErrorProvider` para mostrar errores específicos por campo.
* Validaciones en tiempo de ejecución para asegurar integridad de datos antes de crear objetos.

## 🚀 Cómo ejecutar

1. Abre el proyecto en Visual Studio.
2. Ejecuta la solución desde `FormularioAcceso.cs`.
3. Usa las credenciales:

   * Usuario: `admin`
   * Clave: `1234`

## 📌 Consideraciones

* No utiliza base de datos; todos los datos se mantienen en memoria durante la ejecución.
* Navegación entre formularios controlada con `Show()` y `Hide()` o `Close()`.

## 🛠 Próximas mejoras

* Implementar almacenamiento persistente (base de datos SQL).
* Agregar edición y eliminación de clientes/contactos.
* Reportes básicos o exportación de registros.

---

Desarrollado como parte del módulo **Taller de Programación** en AIEP 🧑‍💻
