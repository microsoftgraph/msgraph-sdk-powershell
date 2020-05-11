
# Create an application for use with DeviceCodeFlow
$app1 = new-mgApplication   -displayName "DeviceCodeFlowApp" `
                            -IsFallbackPublicClient `
                            -PublicClientRedirectUris "https://login.microsoftonline.com/common/oauth2/nativeclient"

# Create an application for use with Native Client an interactive sign in
$app2 = new-mgApplication   -displayName "NativeAppInteractiveFlowApp" `
                            -IsFallbackPublicClient `
                            -PublicClientRedirectUris "http://localhost"

                            