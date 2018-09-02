const COSMOS = (function () {
    var popup;

    //When the oauth window finishes, it will trigger this callback...
    window.addEventListener("message", function (event) {

        //Close the popup and proceed to the correct page
        popup.close();
        if (event.data === 'login') {
            window.location = '/home.aspx';
        } else {
            window.location = '/register.aspx';
        }
    });
    
    return {
        login: function (service, cb) {
            var redirect = window.location.origin + window.location.pathname+'oauth.aspx';
            var loginUrl = 'https://heinemann.cosmos.school/v1/oauth2/auth?redirect_uri='+redirect;
            if (service) {
                loginUrl += '&service=' + service
            }

           popup = window.open(loginUrl, 'SSO Login', 'location=0,status=0,width=800,height=400');
        }
    };
}());
