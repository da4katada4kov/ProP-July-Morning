<?php
include('php/Connection.php');
include ('includes/header.php');
include('php/session.php');
;?>


    
        <meta charset="UTF-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"> 
        <link rel="icon" type="image/logotitle.png" href="images/logotitle.png" sizes="32x32">
        <meta name="keywords" content="July,Morning" />
        <link rel="stylesheet" type="text/css" href="css/demoG.css" />
        <meta charset="utf-8">
        <link rel="stylesheet" type="text/css" href="css/BuyTicket.css">
        <link rel="stylesheet" type="text/css" href="css/demoG.css"/>
        <link rel="stylesheet" type="text/css" href="css/style4.css"/>
        <script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/js/bootstrap.min.js"></script>
        <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
        <script src="//code.jquery.com/jquery-1.10.2.js"></script>
        <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
        <link rel="stylesheet" href="/resources/demos/style.css">
        
        <!-- Load jQuery and the validate plugin -->
        <script src="js/jquery.js"></script>
        <script src="js/jquery.validate.js"></script>
        
    <script src="//code.jquery.com/jquery-1.9.1.js"></script>
    <script src="//ajax.aspnetcdn.com/ajax/jquery.validate/1.9/jquery.validate.min.js"></script>
   


<h1 id="title">Buy Ticket</h1>


<div class="box4e2">
<form  method="POST" name="register-form" >
    <br>
    <label>First name: </label>
    <input type="text" name="firstname" maxlength="50" class="input" required>
    <br><br><br>
    <label>Last name: </label> 
    <input type="text" name="lastname" maxlength="50" class="input" required>
    <br><br><br>
    <label> Date of birth: </label>
    <input type="date" name="dob" class="input" required>
    <br><br><br><br><br>
    <label>Gender:</label>
    <input type="radio" name="gender" id = "gender" value="F"><p>Female</p>
    <input type="radio" name="gender" id = "gender" checked="" value="M"><p>Male</p>
    <br>
    <label>E-mail: </label> <input type="email" name="email" maxlength="50" value="" class="input" required>
    <br>
    <input type="submit" value="Continue" class="btn">

</form>
</div>

<?php
include 'includes/footer.php';
            require('php/formvalidation.php');
?>
