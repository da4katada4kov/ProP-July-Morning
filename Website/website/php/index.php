<?php
include('php/Connection.php');
include('php/login.php');
?>
<!DOCTYPE html>
<html lang="en">
    <head>
        <title>July Morning Event</title>
        <link rel="icon" type="image/logotitle.png" href="images/logotitle.png" sizes="32x32">
        <meta charset="UTF-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"> 
        <meta name="viewport" content="width=device-width, initial-scale=1.0"> 
        <link rel="shortcut icon" href="../favicon.ico"> 
        <link rel="stylesheet" type="text/css" href="css/style-mobile">
        <link rel="stylesheet" type="text/css" href="css/demo.css" />
        <link rel="stylesheet" type="text/css" href="css/style7.css" />       
        <link href='http://fonts.googleapis.com/css?family=Josefin+Slab' rel='stylesheet' type='text/css' />

    </head>
    <body >

        <h1><img height="30" width = "35" src = "images/logo5.png">
            July Morning <span>event</span>
        </h1>
        <div id="hide">
        Log in:
        <form  method = "post" id="login">
            Email: <input type="email" name="email" size="10" maxlength = "40" required="" /><br>
            <!--ID: <input type="text" name="id" size="10" maxlength = "16" required=""/><br>-->
                    <input type = "submit" value = "Log in"  />
        </form>
        </div>
        <div id="hidden">
            <h2 id="nameLogged"></h2>
            <a href="php/logout.php">Logout</a>
        </div>
        <div class="container">


            <div class="content">
                <ul class="bmenu">
                    <li class="dell"><a href="#">  </a></li>
                    <li><a href="About.php">About</a></li>
                    <li><a href="Gallery.php">Gallery</a></li>
                    <li><a href="Location.php">Location</a></li>
                    <li><a href="BuyTicket.php">Buy Ticket</a></li>

                </ul>

            </div>
            <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js"></script>
            <script>
        $('#hide').show();
        $('#hidden').hide();
         </script>"
<?php
   include 'includes/footer.php';
?>
