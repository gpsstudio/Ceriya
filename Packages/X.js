<manifest ...>

    <!-- Include required permissions for Google Mobile Ads to run-->
    <uses-permission android:name="android.permission.INTERNET" />
    <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />

    <application>

     //...

        <!--Include the AdActivity configChanges and theme. -->
        <activity android:name="com.google.android.gms.ads.AdActivity"
            android:configChanges="keyboard|keyboardHidden|orientation|screenLayout|uiMode|screenSize|smallestScreenSize"
            android:theme="@android:style/Theme.Translucent" />
    </application>
</manifest>