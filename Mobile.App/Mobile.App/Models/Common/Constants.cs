using System;
using System.Collections.Generic;

namespace Mobile.App.Models.Common
{
    public class Constants
    {
        public const int ServiceTimeout = 7000;


        public struct ErrorTypes
        {
            public const string Service = "Service";
            public const string ViewModel = "ViewModel";
        }
        public struct ConfirmationDialog
        {
            public const string Title = "";
            public const string Message = "¿Realmente desea salir?. Perderá los cambios";
            public const string Accept = "Sí";
            public const string Cancel = "No";

            // For iOS
            public const string TextColorForiOS = "#005087";
            public const string BackTextForiOS = "Back";
            public const string ImageBackForiOS = "iosbackarrow.png";
        }
        public struct Views
        {
            public const string ProductList = "Lista de productos.";
            public const string ThanksForPurchase = "Gracias por comprar por Ripley Express.";
            public const string ScanProduct = "Escaneo de producto.";
            public const string RemovePiochas = "Remover piochas.";
            public const string PaymentGateway = "Desliza tu tarjeta.";
            public const string Payment = "Pago de tarjeta.";
            public const string LoginView = "Login vendedor.";
        }

        public struct Actions
        {
            public const string ScanProduct = "Escaneo de producto.";
            public const string RemoveProductSKU = "Remover producto: {0}.";
            public const string ScanProductSKU = "Escaneo de producto: {0}.";
            public const string ScanCoupon = "Escaneo de cupón.";
            public const string RemoveCouponCode = "Remover cupón: {0}.";
            public const string PrintBoleta = "Impresión de la boleta.";
            public const string PassCard = "Deslizar la tarjeta.";
            public const string Payment = "Pago de tarjeta.";
            public const string ShowTermsAndConditions = "Ver términos y condiciones.";
            public const string ShowPersonalData = "Ver términos de informacion personal.";
            public const string LoginSendData = "Logueo de usuario.";
            public const string LoginSendDataCode = "Logueo de usuario: {0}";
            public const string NavigateToPaymentGateway = "Navegación pantalla Desliza tu tarjeta.";
            public const string NavigateToCloseSession = "Navegación pantalla login. - Cierre sesión.";
            public const string NavigateToListProduct = "Navegación Pantalla Lista de Producto.";
            public const string NavigateToThanksForPurchase = "Navegación pantalla gracias por comprar por Ripley Express.";
            public const string NavigateToThanksForPurchase2 = "Navegación segunda pantalla gracias por comprar por Ripley Express.";
            public const string NavigateToPayment = "Navegación a la pantalla de pago de tarjeta.";
            public const string NavigateToPiochas = "Navegación a pantalla remueve las piochas.";
            public const string NavigateToLogin = "Navegación a la pantalla de login.";
            public const string NavigateToScanProduct = "Navegación a la pantalla de Escaneo de Producto.";
        }

        public enum KeyboardListening
        {
            Card,
            Coupon,
            Dni,
            Sku,
            None
        }

        public struct HttpMethod
        {
            public const string Get = "Get";
            public const string Post = "Post";
            public const string Put = "Put";
        }

        public struct Parameter
        {
            public const string LoginBackground = "INIC";
            public const string AcceptTerms = "DTYC";
            public const string AcceptPolicy = "DPDP";
            public const string InactivityTime = "INACTIVITY_TIME";
            public const string InactivityAlertTime = "INACTIVITY_TIME_ALERT";
            public const string InactivityAlertText = "INACTIVITY_TEXT";
            public const string OptionCard = "A";
            public const string CoinType = "MONN";
            public const string SuccessfulImage = "INPF";
            public const string ParameterCredit = "CSTC";
            public const string ParameterEfectivo = "CSSE";
            public const string ParameterTimeOut = "TRSE";
            public const string PhoneNumberL = "TELL";
            public const string PhoneNumberP = "TELP";
            public const string VersionIos = "VIOS";
            public const string VersionAndroid = "VAND";
            public const string TypeCoint = "APP007";
            public const string LegalConditionParameter = "APP003";
            public const string ChangeTicketParameter = "CHANGE_TICKET";
            public const string SecretSku = "SKU_SECRET";
            public const string TermsAndCondition = "TERMSYCONDITIONS";
            public const string TitleTermsCondition = "TITLE_TERMSYCONDITIONS";
            public const string TimeParameter = "FAREWELL_SCREEN_TIME";
            public const string AmountParamter = "MOUNT_VALIDATION";
        }

        public struct HttpCode
        {
            //OK 200
            public const int OkCode200 = 200; //Usuario sin enrolar

            public const int OkCode202 = 202; //Usuario enrolado

            //Error 400

            public const int ErrorCode504 = 504; //Conflict

            public const int ErrorCode409 = 409; //Conflict

            public const int ErrorCode517 = 517; //Wifi off

            public const int ErrorCode518 = 518; //Error de app

            public const int ErrorCode519 = 519; //No se autenticó la llamada al servicio GetPromotions (401)

            public const int ErrorCode520 = 520; //Any other code exception

            //Exception generic

            public const int ErrorCode599 = 599; //Ocurrio un error no registrado


            //Exception PMM	

            public const int ErrorCode521 = 521; // No se tiene permisos de acceso sobre el servicio PMM
            public const int ErrorCode522 = 522; //	No se logro una conexión con el servicio PMM
            public const int ErrorCode523 = 523; // Se sobrepaso el Timeout en el servicio PMM
            public const int ErrorCode524 = 524;   //Error interno por parte del servicio PMM
            public const int ErrorCode525 = 525;   //No se encuentra disponible el servicio de PMM
            public const int ErrorCode526 = 526;   //Se sobrepaso el Timeout en el servicio PMM
            public const int ErrorCode527 = 527;//	Codigo SKU no registrado

            //Exception Start Transaction	

            public const int ErrorCode528 = 528; //	No se tiene permisos de acceso sobre el servicio StartTransaction del Orquestador
            public const int ErrorCode529 = 529; //	No se logro una conexión con el servicio StartTransaction del Orquestador
            public const int ErrorCode530 = 530; //	Se sobrepaso el Timeout en el servicio StartTransaction del Orquestador
            public const int ErrorCode531 = 531; //  Error interno por parte del servicio StartTransaction del Orquestador
            public const int ErrorCode532 = 532; //	No se encuentra disponible el servicio de StartTransaction del Orquestador
            public const int ErrorCode533 = 533; //	Se sobrepaso el Timeout en el servicio StartTransaction del Orquestador
            public const int ErrorCode534 = 534; //	Error controlado por parte del servicio de StartTransaction del Orquestador
                                                 //Exception Item Entry GetRewards	
            public const int ErrorCode535 = 535; //	No se tiene permisos de acceso sobre el servicio ItemEntryGetRewards del Orquestador
            public const int ErrorCode536 = 536; //	No se logro una conexión con el servicio ItemEntryGetRewards del Orquestador
            public const int ErrorCode537 = 537; //	Se sobrepaso el Timeout en el servicio ItemEntryGetRewards del Orquestador
            public const int ErrorCode538 = 538; //	Error interno por parte del servicio ItemEntryGetRewards del Orquestador
            public const int ErrorCode539 = 539; // No se encuentra disponible el servicio de ItemEntryGetRewards del Orquestador
            public const int ErrorCode540 = 540; //	Se sobrepaso el Timeout en el servicio ItemEntryGetRewards del Orquestador
            public const int ErrorCode541 = 541; //Error controlado por parte del servicio de ItemEntryGetRewards del Orquestador

            //Exception Item Entry List GetRewards	
            public const int ErrorCode542 = 542; //No se tiene permisos de acceso sobre el servicio ItemEntryListGetRewards del Orquestador
            public const int ErrorCode543 = 543;   //No se logro una conexión con el servicio ItemEntryListGetRewards del Orquestador
            public const int ErrorCode544 = 544;   //Se sobrepaso el Timeout en el servicio ItemEntryListGetRewards del Orquestador
            public const int ErrorCode545 = 545;   //Error interno por parte del servicio ItemEntryListGetRewards del Orquestador
            public const int ErrorCode546 = 546;   //No se encuentra disponible el servicio de ItemEntryListGetRewards del Orquestador
            public const int ErrorCode547 = 547;   //Se sobrepaso el Timeout en el servicio ItemEntryListGetRewards del Orquestador
            public const int ErrorCode548 = 548;   //Error controlado por parte del servicio de ItemEntryListGetRewards del Orquestador

            //Exception Tender Entry GetRewards	
            public const int ErrorCode549 = 549;   //No se tiene permisos de acceso sobre el servicio TenderEntryGetRewards del Orquestador
            public const int ErrorCode550 = 550;   //No se logro una conexión con el servicio TenderEntryGetRewards del Orquestador
            public const int ErrorCode551 = 551;   //Se sobrepaso el Timeout en el servicio TenderEntryGetRewards del Orquestador
            public const int ErrorCode552 = 552;   //Error interno por parte del servicio TenderEntryGetRewards del Orquestador
            public const int ErrorCode553 = 553;   //No se encuentra disponible el servicio de TenderEntryGetRewards del Orquestador
            public const int ErrorCode554 = 554;   //Se sobrepaso el Timeout en el servicio TenderEntryGetRewards del Orquestador
            public const int ErrorCode555 = 555;   //Error controlado por parte del servicio de TenderEntryGetRewards del Orquestador

            //Exception End Transaction	
            public const int ErrorCode556 = 556;   //No se tiene permisos de acceso sobre el servicio EndTransaction del Orquestador
            public const int ErrorCode557 = 557;   //No se logro una conexión con el servicio EndTransaction del Orquestador
            public const int ErrorCode558 = 558;   //Se sobrepaso el Timeout en el servicio EndTransaction del Orquestador
            public const int ErrorCode559 = 559;   //Error interno por parte del servicio EndTransaction del Orquestador
            public const int ErrorCode560 = 560;   //No se encuentra disponible el servicio de EndTransaction del Orquestador
            public const int ErrorCode561 = 561;   //Se sobrepaso el Timeout en el servicio EndTransaction del Orquestador
            public const int ErrorCode562 = 562;   //Error controlado por parte del servicio de EndTransaction del Orquestador

            //Exception Get Subsidiary By Code	
            public const int ErrorCode563 = 563;   //No se tiene permisos de acceso sobre el servicio GetSubsidiaryByCode de Parametros
            public const int ErrorCode564 = 564;   //No se logro una conexión con el servicio GetSubsidiaryByCode del Parametros
            public const int ErrorCode565 = 565;   //Se sobrepaso el Timeout en el servicio GetSubsidiaryByCode del Parametros
            public const int ErrorCode566 = 566;   //Error interno por parte del servicio GetSubsidiaryByCode del Parametros
            public const int ErrorCode567 = 567;	//No se encuentra disponible el servicio de GetSubsidiaryByCode del Parametros
            public const int ErrorCode568 = 568;   //Se sobrepaso el Timeout en el servicio GetSubsidiaryByCode del Parametros
            public const int ErrorCode569 = 569;	//No se encontro ninguna sede que pertenezca al codigo ingresado

            //Exception Get Season	
            public const int ErrorCode570 = 570;   //No se tiene permisos de acceso sobre el servicio GetSeason de Parametros
            public const int ErrorCode571 = 571;   //No se logro una conexión con el servicio GetSeason del Parametros
            public const int ErrorCode572 = 572;	//Se sobrepaso el Timeout en el servicio GetSeason del Parametros
            public const int ErrorCode573 = 573;   //Error interno por parte del servicio GetSeason del Parametros
            public const int ErrorCode574 = 574;   //No se encuentra disponible el servicio de GetSeason del Parametros
            public const int ErrorCode575 = 575;   //Se sobrepaso el Timeout en el servicio GetSeason del Parametros
            public const int ErrorCode576 = 576;   //No se encontraron temporadas activas

            //Exception Get Parameter By Code	
            public const int ErrorCode577 = 577;   //No se tiene permisos de acceso sobre el servicio GetParameterByCode de Parametros
            public const int ErrorCode578 = 578;   //No se logro una conexión con el servicio GetParameterByCode del Parametros
            public const int ErrorCode579 = 579;   //Se sobrepaso el Timeout en el servicio GetParameterByCode del Parametros
            public const int ErrorCode580 = 580;   //Error interno por parte del servicio GetParameterByCode del Parametros
            public const int ErrorCode581 = 581;   //No se encuentra disponible el servicio de GetParameterByCode del Parametros
            public const int ErrorCode582 = 582;   //Se sobrepaso el Timeout en el servicio GetParameterByCode del Parametros
            public const int ErrorCode583 = 583;   //No se encontro ningún registro de CARD_TYPE en la colección de parameteros

            //Exception Get Persona	
            public const int ErrorCode584 = 584;   //Codigo de empleado no registrado

            //Exception Promotions	
            public const int ErrorCode585 = 585;   //La lista de productos se encuentra vacia
            public const int ErrorCode586 = 586;   //SKUs con Caracteres extraños
            public const int ErrorCode587 = 587;   //Error de Cálculo
            public const int ErrorCode588 = 588;    //Direccion MAC no enviada
            public const int ErrorCode589 = 589; //Cupon invalido
            public const int ErrorCode590 = 590; //Ocurrió un error al procesar el pago

        }


        public struct LoginMessage
        {
            //Error Login
            public const int ClienteInvalido = 1;
        }

        public struct ErrorMessage
        {
            //Error 400
            public const string ErrorMessage409 = "Se ha producido un error inesperado";

            //Timeout
            public const string ErrorMessage504 = "Se ha producido un error inesperado, Por favor comuniquese con el supervisor";

            public const string ErrorMessage517 = "Se ha producido un error inesperado";

            public const string ErrorMessage518 = "Se ha producido un error inesperado";


            public const string ErrorMessage519 = "Se ha producido un error inesperado";


            public const string ErrorMessage520 = "Se ha producido un error inesperado";

            //Exception generic

            public const string ErrorMessage599 = "Se ha producido un error inesperado";


            //Exception PMM	

            public const string ErrorMessage521 = "Se ha producido un error inesperado";
            public const string ErrorMessage522 = "Se ha producido un error inesperado";
            public const string ErrorMessage523 = "Se ha producido un error inesperado";
            public const string ErrorMessage524 = "Se ha producido un error inesperado";
            public const string ErrorMessage525 = "Se ha producido un error inesperado";
            public const string ErrorMessage526 = "Se ha producido un error inesperado";
            public const string ErrorMessage527 = "Se ha producido un error inesperado";

            //Exception Start Transaction	

            public const string ErrorMessage528 = "Se ha producido un error inesperado";
            public const string ErrorMessage529 = "Se ha producido un error inesperado";
            public const string ErrorMessage530 = "Se ha producido un error inesperado";
            public const string ErrorMessage531 = "Se ha producido un error inesperado";
            public const string ErrorMessage532 = "Se ha producido un error inesperado";
            public const string ErrorMessage533 = "Se ha producido un error inesperado";
            public const string ErrorMessage534 = "Se ha producido un error inesperado";
            //Exception Item Entry GetRewards	
            public const string ErrorMessage535 = "Se ha producido un error inesperado";
            public const string ErrorMessage536 = "Se ha producido un error inesperado";
            public const string ErrorMessage537 = "Se ha producido un error inesperado";
            public const string ErrorMessage538 = "Se ha producido un error inesperado";
            public const string ErrorMessage539 = "Se ha producido un error inesperado";
            public const string ErrorMessage540 = "Se ha producido un error inesperado";
            public const string ErrorMessage541 = "Se ha producido un error inesperado";

            //Exception Item Entry List GetRewards	
            public const string ErrorMessage542 = "Se ha producido un error inesperado";
            public const string ErrorMessage543 = "Se ha producido un error inesperado";
            public const string ErrorMessage544 = "Se ha producido un error inesperado";
            public const string ErrorMessage545 = "Se ha producido un error inesperado";
            public const string ErrorMessage546 = "Se ha producido un error inesperado";
            public const string ErrorMessage547 = "Se ha producido un error inesperado";
            public const string ErrorMessage548 = "Se ha producido un error inesperado";

            //Exception Tender Entry GetRewards	
            public const string ErrorMessage549 = "Se ha producido un error inesperado";
            public const string ErrorMessage550 = "Se ha producido un error inesperado";
            public const string ErrorMessage551 = "Se ha producido un error inesperado";
            public const string ErrorMessage552 = "Se ha producido un error inesperado";
            public const string ErrorMessage553 = "Se ha producido un error inesperado";
            public const string ErrorMessage554 = "Se ha producido un error inesperado";
            public const string ErrorMessage555 = "Se ha producido un error inesperado";

            //Exception End Transaction	
            public const string ErrorMessage556 = "Se ha producido un error inesperado";
            public const string ErrorMessage557 = "Se ha producido un error inesperado";
            public const string ErrorMessage558 = "Se ha producido un error inesperado";
            public const string ErrorMessage559 = "Se ha producido un error inesperado";
            public const string ErrorMessage560 = "Se ha producido un error inesperado";
            public const string ErrorMessage561 = "Se ha producido un error inesperado";
            public const string ErrorMessage562 = "Se ha producido un error inesperado";

            //Exception Get Subsidiary By Code	
            public const string ErrorMessage563 = "Se ha producido un error inesperado";
            public const string ErrorMessage564 = "Se ha producido un error inesperado";
            public const string ErrorMessage565 = "Se ha producido un error inesperado";
            public const string ErrorMessage566 = "Se ha producido un error inesperado";
            public const string ErrorMessage567 = "Se ha producido un error inesperado";
            public const string ErrorMessage568 = "Se ha producido un error inesperado";
            public const string ErrorMessage569 = "Se ha producido un error inesperado";

            //Exception Get Season	
            public const string ErrorMessage570 = "Se ha producido un error inesperado";
            public const string ErrorMessage571 = "Se ha producido un error inesperado";
            public const string ErrorMessage572 = "Se ha producido un error inesperado";
            public const string ErrorMessage573 = "Se ha producido un error inesperado";
            public const string ErrorMessage574 = "Se ha producido un error inesperado";
            public const string ErrorMessage575 = "Se ha producido un error inesperado";
            public const string ErrorMessage576 = "Se ha producido un error inesperado";

            //Exception Get Parameter By Code	
            public const string ErrorMessage577 = "Se ha producido un error inesperado";
            public const string ErrorMessage578 = "Se ha producido un error inesperado";
            public const string ErrorMessage579 = "Se ha producido un error inesperado";
            public const string ErrorMessage580 = "Se ha producido un error inesperado";
            public const string ErrorMessage581 = "Se ha producido un error inesperado";
            public const string ErrorMessage582 = "Se ha producido un error inesperado";
            public const string ErrorMessage583 = "Se ha producido un error inesperado";

            //Exception Get Persona	
            public const string ErrorMessage584 = "Codigo de empleado no registrado";

            //Exception Promotions	
            public const string ErrorMessage585 = "La lista de productos se encuentra vacia";
            public const string ErrorMessage586 = "SKUs con Caracteres extraños";
            public const string ErrorMessage587 = "Error de Cálculo";
            public const string ErrorMessage588 = "Direccion MAC no enviada";
            public const string ErrorMessage589 = "Cupón inválido";
            public const string ErrorMessage590 = "Ocurrió un error al procesar el pago.";

            /* public const string ErrorMessage519 = "No se autenticó la llamada al servicio GetPromotions(401)";


             public const string ErrorMessage520 = "Error no reconocido";

             //Exception generic

             public const string ErrorMessage599 = "Ocurrio un error no registrado";


             //Exception PMM	

             public const string ErrorMessage521 = "No se tiene permisos de acceso sobre el servicio PMM";
             public const string ErrorMessage522 = "No se logro una conexión con el servicio PMM";
             public const string ErrorMessage523 = "Se sobrepaso el Timeout en el servicio PMM";
             public const string ErrorMessage524 = "Error interno por parte del servicio PMM2";
             public const string ErrorMessage525 = "No se encuentra disponible el servicio de PMM";
             public const string ErrorMessage526 = "Se sobrepaso el Timeout en el servicio PMM";
             public const string ErrorMessage527 = "Codigo SKU no registrado";

             //Exception Start Transaction	

             public const string ErrorMessage528 = "No se tiene permisos de acceso sobre el servicio StartTransaction del Orquestador";
             public const string ErrorMessage529 = "No se logro una conexión con el servicio StartTransaction del Orquestador";
             public const string ErrorMessage530 = "Se sobrepaso el Timeout en el servicio StartTransaction del Orquestador";
             public const string ErrorMessage531 = "Error interno por parte del servicio StartTransaction del Orquestador";
             public const string ErrorMessage532 = "No se encuentra disponible el servicio de StartTransaction del Orquestador";
             public const string ErrorMessage533 = "Se sobrepaso el Timeout en el servicio StartTransaction del Orquestador";
             public const string ErrorMessage534 = "Error controlado por parte del servicio de StartTransaction del Orquestador";
             //Exception Item Entry GetRewards	
             public const string ErrorMessage535 = "No se tiene permisos de acceso sobre el servicio ItemEntryGetRewards del Orquestador";
             public const string ErrorMessage536 = "No se logro una conexión con el servicio ItemEntryGetRewards del Orquestador";
             public const string ErrorMessage537 = "Se sobrepaso el Timeout en el servicio ItemEntryGetRewards del Orquestador";
             public const string ErrorMessage538 = "Error interno por parte del servicio ItemEntryGetRewards del Orquestador";
             public const string ErrorMessage539 = "No se encuentra disponible el servicio de ItemEntryGetRewards del Orquestador";
             public const string ErrorMessage540 = "Se sobrepaso el Timeout en el servicio ItemEntryGetRewards del Orquestador";
             public const string ErrorMessage541 = "Error controlado por parte del servicio de ItemEntryGetRewards del Orquestador";

             //Exception Item Entry List GetRewards	
             public const string ErrorMessage542 = "No se tiene permisos de acceso sobre el servicio ItemEntryListGetRewards del Orquestador";
             public const string ErrorMessage543 = "No se logro una conexión con el servicio ItemEntryListGetRewards del Orquestador";
             public const string ErrorMessage544 = "Se sobrepaso el Timeout en el servicio ItemEntryListGetRewards del Orquestador";
             public const string ErrorMessage545 = "Error interno por parte del servicio ItemEntryListGetRewards del Orquestador";
             public const string ErrorMessage546 = "No se encuentra disponible el servicio de ItemEntryListGetRewards del Orquestador";
             public const string ErrorMessage547 = "Se sobrepaso el Timeout en el servicio ItemEntryListGetRewards del Orquestador";
             public const string ErrorMessage548 = "Error controlado por parte del servicio de ItemEntryListGetRewards del Orquestador";

             //Exception Tender Entry GetRewards	
             public const string ErrorMessage549 = "No se tiene permisos de acceso sobre el servicio TenderEntryGetRewards del Orquestador";
             public const string ErrorMessage550 = "No se logro una conexión con el servicio TenderEntryGetRewards del Orquestador";
             public const string ErrorMessage551 = "Se sobrepaso el Timeout en el servicio TenderEntryGetRewards del Orquestador";
             public const string ErrorMessage552 = "Error interno por parte del servicio TenderEntryGetRewards del Orquestador";
             public const string ErrorMessage553 = "No se encuentra disponible el servicio de TenderEntryGetRewards del Orquestador";
             public const string ErrorMessage554 = "Se sobrepaso el Timeout en el servicio TenderEntryGetRewards del Orquestador";
             public const string ErrorMessage555 = "Error controlado por parte del servicio de TenderEntryGetRewards del Orquestador";

             //Exception End Transaction	
             public const string ErrorMessage556 = "No se tiene permisos de acceso sobre el servicio EndTransaction del Orquestador";
             public const string ErrorMessage557 = "No se logro una conexión con el servicio EndTransaction del Orquestador";
             public const string ErrorMessage558 = "Se sobrepaso el Timeout en el servicio EndTransaction del Orquestador";
             public const string ErrorMessage559 = "Error interno por parte del servicio EndTransaction del Orquestador";
             public const string ErrorMessage560 = "No se encuentra disponible el servicio de EndTransaction del Orquestador";
             public const string ErrorMessage561 = "Se sobrepaso el Timeout en el servicio EndTransaction del Orquestador";
             public const string ErrorMessage562 = "Error controlado por parte del servicio de EndTransaction del Orquestador";

             //Exception Get Subsidiary By Code	
             public const string ErrorMessage563 = "No se tiene permisos de acceso sobre el servicio GetSubsidiaryByCode de Parametros";
             public const string ErrorMessage564 = "No se logro una conexión con el servicio GetSubsidiaryByCode del Parametros";
             public const string ErrorMessage565 = "Se sobrepaso el Timeout en el servicio GetSubsidiaryByCode del Parametros";
             public const string ErrorMessage566 = "Error interno por parte del servicio GetSubsidiaryByCode del Parametros";
             public const string ErrorMessage567 = "No se encuentra disponible el servicio de GetSubsidiaryByCode del Parametros";
             public const string ErrorMessage568 = "Se sobrepaso el Timeout en el servicio GetSubsidiaryByCode del Parametros";
             public const string ErrorMessage569 = "No se encontro ninguna sede que pertenezca al codigo ";

             //Exception Get Season	
             public const string ErrorMessage570 = "No se tiene permisos de acceso sobre el servicio GetSeason de Parametros";
             public const string ErrorMessage571 = "No se logro una conexión con el servicio GetSeason del Parametros";
             public const string ErrorMessage572 = "Se sobrepaso el Timeout en el servicio GetSeason del Parametros";
             public const string ErrorMessage573 = "Error interno por parte del servicio GetSeason del Parametros";
             public const string ErrorMessage574 = "No se encuentra disponible el servicio de GetSeason del Parametros";
             public const string ErrorMessage575 = "Se sobrepaso el Timeout en el servicio GetSeason del Parametros";
             public const string ErrorMessage576 = "No se encontraron temporadas activas";

             //Exception Get Parameter By Code	
             public const string ErrorMessage577 = "No se tiene permisos de acceso sobre el servicio GetParameterByCode de Parametros";
             public const string ErrorMessage578 = "No se logro una conexión con el servicio GetParameterByCode del Parametros";
             public const string ErrorMessage579 = "Se sobrepaso el Timeout en el servicio GetParameterByCode del Parametros";
             public const string ErrorMessage580 = "Error interno por parte del servicio GetParameterByCode del Parametros";
             public const string ErrorMessage581 = "No se encuentra disponible el servicio de GetParameterByCode del Parametros";
             public const string ErrorMessage582 = "Se sobrepaso el Timeout en el servicio GetParameterByCode del Parametros";
             public const string ErrorMessage583 = "No se encontro ningún registro de CARD_TYPE en la colección de parameteros";

             //Exception Get Persona	
             public const string ErrorMessage584 = "Codigo de empleado no registrado";

             //Exception Promotions	
             public const string ErrorMessage585 = "La lista de productos se encuentra vacia";
             public const string ErrorMessage586 = "SKUs con Caracteres extraños";
             public const string ErrorMessage587 = "Error de Cálculo";
             public const string ErrorMessage588 = "Direccion MAC no enviada";*/

        }

        private static Dictionary<int, string> _errorServiceDictionary = new Dictionary<int, string>()
        {
            //Error 400
            {HttpCode.ErrorCode409,ErrorMessage.ErrorMessage409},
            {HttpCode.ErrorCode504,ErrorMessage.ErrorMessage504},
            {HttpCode.ErrorCode521,ErrorMessage.ErrorMessage521},
            {HttpCode.ErrorCode522,ErrorMessage.ErrorMessage522},
            {HttpCode.ErrorCode523,ErrorMessage.ErrorMessage523},
            {HttpCode.ErrorCode524,ErrorMessage.ErrorMessage524},
            {HttpCode.ErrorCode525,ErrorMessage.ErrorMessage525},
            {HttpCode.ErrorCode526,ErrorMessage.ErrorMessage526},
            {HttpCode.ErrorCode527,ErrorMessage.ErrorMessage527},
            {HttpCode.ErrorCode528,ErrorMessage.ErrorMessage528},
            {HttpCode.ErrorCode529,ErrorMessage.ErrorMessage529},
            {HttpCode.ErrorCode530,ErrorMessage.ErrorMessage530},
            {HttpCode.ErrorCode531,ErrorMessage.ErrorMessage531},
            {HttpCode.ErrorCode532,ErrorMessage.ErrorMessage532},
            {HttpCode.ErrorCode533,ErrorMessage.ErrorMessage533},
            {HttpCode.ErrorCode534,ErrorMessage.ErrorMessage534},
            {HttpCode.ErrorCode535,ErrorMessage.ErrorMessage535},
            {HttpCode.ErrorCode536,ErrorMessage.ErrorMessage536},
            {HttpCode.ErrorCode537,ErrorMessage.ErrorMessage537},
            {HttpCode.ErrorCode538,ErrorMessage.ErrorMessage538},
            {HttpCode.ErrorCode539,ErrorMessage.ErrorMessage539},
            {HttpCode.ErrorCode540,ErrorMessage.ErrorMessage540},
            {HttpCode.ErrorCode541,ErrorMessage.ErrorMessage541},
            {HttpCode.ErrorCode542,ErrorMessage.ErrorMessage542},
            {HttpCode.ErrorCode543,ErrorMessage.ErrorMessage543},
            {HttpCode.ErrorCode544,ErrorMessage.ErrorMessage544},
            {HttpCode.ErrorCode545,ErrorMessage.ErrorMessage545},
            {HttpCode.ErrorCode546,ErrorMessage.ErrorMessage546},
            {HttpCode.ErrorCode547,ErrorMessage.ErrorMessage547},
            {HttpCode.ErrorCode548,ErrorMessage.ErrorMessage548},
            {HttpCode.ErrorCode549,ErrorMessage.ErrorMessage549},
            {HttpCode.ErrorCode550,ErrorMessage.ErrorMessage550},
            {HttpCode.ErrorCode551,ErrorMessage.ErrorMessage551},
            {HttpCode.ErrorCode552,ErrorMessage.ErrorMessage552},
            {HttpCode.ErrorCode553,ErrorMessage.ErrorMessage553},
            {HttpCode.ErrorCode554,ErrorMessage.ErrorMessage554},
            {HttpCode.ErrorCode555,ErrorMessage.ErrorMessage555},
            {HttpCode.ErrorCode556,ErrorMessage.ErrorMessage556},
            {HttpCode.ErrorCode557,ErrorMessage.ErrorMessage557},
            {HttpCode.ErrorCode558,ErrorMessage.ErrorMessage558},
            {HttpCode.ErrorCode559,ErrorMessage.ErrorMessage559},
            {HttpCode.ErrorCode560,ErrorMessage.ErrorMessage560},
            {HttpCode.ErrorCode561,ErrorMessage.ErrorMessage561},
            {HttpCode.ErrorCode562,ErrorMessage.ErrorMessage562},
            {HttpCode.ErrorCode563,ErrorMessage.ErrorMessage563},
            {HttpCode.ErrorCode564,ErrorMessage.ErrorMessage564},
            {HttpCode.ErrorCode565,ErrorMessage.ErrorMessage565},
            {HttpCode.ErrorCode566,ErrorMessage.ErrorMessage566},
            {HttpCode.ErrorCode567,ErrorMessage.ErrorMessage567},
            {HttpCode.ErrorCode568,ErrorMessage.ErrorMessage568},
            {HttpCode.ErrorCode569,ErrorMessage.ErrorMessage569},
            {HttpCode.ErrorCode570,ErrorMessage.ErrorMessage570},
            {HttpCode.ErrorCode571,ErrorMessage.ErrorMessage571},
            {HttpCode.ErrorCode572,ErrorMessage.ErrorMessage572},
            {HttpCode.ErrorCode573,ErrorMessage.ErrorMessage573},
            {HttpCode.ErrorCode574,ErrorMessage.ErrorMessage574},
            {HttpCode.ErrorCode575,ErrorMessage.ErrorMessage575},
            {HttpCode.ErrorCode576,ErrorMessage.ErrorMessage576},
            {HttpCode.ErrorCode577,ErrorMessage.ErrorMessage577},
            {HttpCode.ErrorCode578,ErrorMessage.ErrorMessage578},
            {HttpCode.ErrorCode579,ErrorMessage.ErrorMessage579},
            {HttpCode.ErrorCode580,ErrorMessage.ErrorMessage580},
            {HttpCode.ErrorCode581,ErrorMessage.ErrorMessage581},
            {HttpCode.ErrorCode582,ErrorMessage.ErrorMessage582},
            {HttpCode.ErrorCode583,ErrorMessage.ErrorMessage583},
            {HttpCode.ErrorCode584,ErrorMessage.ErrorMessage584},
            {HttpCode.ErrorCode585,ErrorMessage.ErrorMessage585},
            {HttpCode.ErrorCode586,ErrorMessage.ErrorMessage586},
            {HttpCode.ErrorCode587,ErrorMessage.ErrorMessage587},
            {HttpCode.ErrorCode588,ErrorMessage.ErrorMessage588},
            {HttpCode.ErrorCode589,ErrorMessage.ErrorMessage589},
            {HttpCode.ErrorCode590,ErrorMessage.ErrorMessage590},
        };

        public static Dictionary<int, string> ErrorServiceDictionary { get { return _errorServiceDictionary; } }

        #region Constants Message
        public struct MessageErrors
        {
            public struct Seller
            {
                public const string NoExists = "El código de vendedor ingresado no existe.";
                public const string Empty = "Debes ingresar el código de vendedor.";
            }

            public struct Product
            {
                public const string InvalidSKU = "Código SKU inválido.";
                public const string ListEmpty = "Debes agregar al menos un producto.";
                public const string MaxNumberList = "El número máximo de items es {0}.";
            }

            public struct Coupon
            {
                public const string Empty = "Debes ingresar el código del cupón.";
                public const string Repeat = "El cupón ingresado ya existe.";
                public const string Invalid = "Cupón inválido.";
                public const string NotApply = "El cupón no aplica para ninguno de los productos.";
            }

            public struct Payment
            {
                public const string CardError = "Ocurrió un error al leer la tarjeta.";
                public const string InvalidCard = "Número de tarjeta inválido.";
                public const string Valid_CardNumber = "Ingresa tu número de tarjeta.";
                public const string Valid_CardDate = "Ingresa la fecha de vencimiento.";
                public const string Valid_CardCVV = "Ingresa el número de CVV.";
                public const string Valid_CardCuotas = "Ingresa la cantidad de cuotas";
                public const string Valid_CardName = "Ingresa tu nombre.";
                public const string Valid_CardLastName = "Ingresa tu apellido.";
                public const string Valid_CardDNI = "Ingresa tu número de DNI.";
                public const string Valid_CardEmail = "Ingresa tu email.";
                public const string Valid_CardPhone = "Ingresa tu número de teléfono.";
                public const string Valid_CardTYC = "Debes aceptar los términos y condiciones.";
                public const string Length_CardNumber = "La tarjeta debe tener más de {0} dígitos.";
                public const string Length_CardDate = "Fecha de vencimiento inválida.";
                public const string Length_CardCVV = "El CVV debe tener 3 dígitos.";
                public const string Length_CardName = "Tu nombre debe tener al menos {0} dígitos.";
                public const string Format_CardName = "Ingresa un nombre válido.";                
                public const string Length_CardLastName = "Tu apellido debe tener al menos {0} dígitos.";
                public const string Format_CardLastName = "Ingresa un apellido válido.";
                public const string Length_CardDNI = "El DNI debe tener {0} dígitos.";
                public const string Length_CardEmail = "Ingresa un email válido.";
                public const string Length_CardPhone = "El teléfono debe tener 9 dígitos.";
                public const string Valid_TYC = "No has aceptado los términos y condiciones.";

                public const string CreateCart = "Ocurrio un error creando el carrito. Por favor, intentelo nuevamente.";
                public const string CreatePay = "Ocurrio un error realizando el pago. Por favor, intentelo nuevamente.";
            }

            public struct Default
            {
                public const string Error = "Ocurrio un error inesperado. Por favor, intentelo nuevamente.";
            }
        }
        #endregion
    }
}