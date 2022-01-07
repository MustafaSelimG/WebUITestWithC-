# Web UI Test With C#
>*libraries* .NET, SpecFlow, NUnit, Selenium
</br>
  **Feature: Test**</br>
    Web UI Tests with .NET & Specflow</br>
</br>
  **Background:**  </br>
  *Given* I launch the website</br>
  *And* I accept the cookies</br>
  *When* navigate the login page</br>
  *And* I enter following details</br>
    | Email                       | Password    |</br>
    | *email*                     | *password*  |</br>
</br>
  *@test1*</br>
  **Scenario: verify the basket is empty**</br>
    *Given* I verify the homepage is open</br>
    *When* I search for electronics from categories</br>
    *And* I click the subcategory sound systems </br>
    *And* I click first product from best seller</br>
    *And* I add product the basket</br>
    *And* I delete product from the basket</br>
    *Then* basket should be empty</br>
</br>
![test1](https://user-images.githubusercontent.com/88919177/148561486-cb46fe8f-f692-4d16-97b7-3c15fcfa95f4.gif)
</br></br>
  *@test2*</br>
  **Scenario: verify the product price**</br>
    *Given* I verify the homepage is open</br>
    *When* I open the deals of the day</br>
    *And* I filter the laptops</br>
    *And* I click the first product</br>
    *Then* product price should be equal</br>
</br>
![test2](https://user-images.githubusercontent.com/88919177/148561506-ba965f7a-69af-4f33-8556-ba68094d0790.gif)
