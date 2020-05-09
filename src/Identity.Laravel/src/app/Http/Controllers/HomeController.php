<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Jumbojett\OpenIDConnectClient;

class HomeController extends Controller
{
    public function show()
    {//TODO: Continue
        // $oidc = new OpenIDConnectClient('https://localhost:5000',
        //                         'laravel',
        //                         'secret');
        // $oidc->providerConfigParam(array('token_endpoint'=>'https://localhost:5000/connect/token'));
        // $oidc->addScope('my_scope');

        // // this assumes success (to validate check if the access_token property is there and a valid JWT) :
        // $clientCredentialsToken = $oidc->requestClientCredentialsToken()->access_token;

        return view('welcome');
    }
}
