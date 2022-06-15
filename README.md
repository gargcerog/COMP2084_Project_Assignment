# COMP2084_Project_Assignment
## Purpose of the application:
- A website that allows the user to book a desktop site in a coworking space or area. The example that is used in this project is from a company that has several branches, and it's implementing this booking system to manage available work palaces for their workers who are returning to work at the office. The users can register, log in to their accounts, and see their reservations. The user can pick from different desks available at different locations, and the website will check if that desk is available for booking or if it has been chosen by someone else. The user can also check the different features of the desk, such as if the desk has another monitor or standing desk.

## Link to the published website on the Azure server:
- https://comp2084projectassignment20220613180634.azurewebsites.net
 
## Sources:
### Home Page
- Office Image: https://pixabay.com/photos/people-man-office-work-computer-2567566/  <br />
                Pixabay License-  Free for commercial use - No attribution required
                
### Favicon
- Favicon Image: https://www.svgrepo.com/svg/54601/desk <br />
                CC0 License, Uploader: SVG Repo
            
### General Layout (Bonus #1):            
- Pre-built theme:  https://bootswatch.com/lux/ <br />
                 MIT License
                
- Own Css modifications: These where added to the code in the "~/css/site.css" document. <br />

## Assitional .NET MVC we have not yet learned in class (Bonus #2):
- Users can register and log in by using a Facebook account.
- For achieving these, a Facebook Service sign-in procedure was Added to the Program.cs was added.
- An app developer account in Facebook was created in order to create the app to manage this authentication. 
- The procedure that was followed as a guide can be found in the following link: 
   https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins?view=aspnetcore-6.0
   
- How authentication works:
  - Go to the Registration page that can be accessed in the navbar by clicking in Register.
  - Loggin to facebook and accept to pop-ups that facebook displays.
  - Write your Email and Click on Register.
  - Confirm your account by clicking the link that appears on the page. 
  - After that, you will be registered. Now you can go to Login by clicking at the navbar and then Login using your Facebook account.


