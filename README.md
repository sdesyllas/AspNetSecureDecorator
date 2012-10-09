AspNetSecureDecorator
=====================

[SecurePage] decorator for web forms

We decorate our page class with SecurePage attribute in order to make sure that this page is loaded through https.
This is an easy way to avoid http replace with https everytime , all we need to do is to decorate our page class with [SecurePage] attribute

The project Xeyanord.SecurePageDecorator includes the SecurePage.cs and its where the magic happens.
The project SecureApplication is a test webforms application that demonstrates the use of SecurePage attribute decorator