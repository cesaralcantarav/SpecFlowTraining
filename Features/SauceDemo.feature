@Login
Feature: Login en la página de SauceDemo

  Scenario: Inicio de sesión exitoso

    Given que el Cliente se encuentra en la página SauceDemo
    When inicia sesión con las credenciales: standard_user, secret_sauce
    Then el login es satisfactorio
