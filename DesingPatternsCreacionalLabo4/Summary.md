**PROBLEMA:**
El problema consiste en desarrollar una estructura capaz de realizar transacciones en un cajero, como retirar o depositar dinero, con un sistema de autenticacion integrado.

**Patron**
El patron empleado para resolucion del problema fue el de fachada el cual hace uso de 4 subsistemas que son el de autenticacion, cajero, cuenta de banco y tarjeta.
Lo que se logro es que trabajen conjuntamente en nuestra clase fachada asi facilitando las solocitudes de trancciones del usuario en un cajero.