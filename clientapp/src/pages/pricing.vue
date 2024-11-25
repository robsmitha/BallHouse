<template>
    <HelloWorld 
        :text="text"
        src="https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/celebrate-cropped.jpg" 
        :height="350" 
    />
    <v-container>
        <v-row>
            <v-col md="4">
                <span class="d-block">
                    Weddings
                </span>
                <span class="d-block">
                    We offer a comprehensive wedding package including our grand lawn ceremony and reception location.
                    Our package also includes:
                </span>
                <v-list>
                    <v-list-item>
                        <v-list-item-content>Use of On-Site Bridal Suite</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Complimentary Parking</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Full Day Rental Block</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>White Chiavari Chairs for Ceremony</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Banquet Tables + Chairs for Reception</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Market Lighting on the Back Lawn</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Package Pricing for Cottage Rentals</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Feb-June and Oct-Dec $4999</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Jan and July-Sep $3999</v-list-item-content>
                    </v-list-item>
                </v-list>
            </v-col>
            <v-col md="4">
                <span class="d-block">
                    Corporate & Social
                </span>
                <span class="d-block">
                    We offer a comprehensive rental package including our outdoor event space and the following:
                </span>
                <v-list>
                    <v-list-item>
                        <v-list-item-content>Use of Manor</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Indoor and Outdoor Event Spaces</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Complimentary Parking</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Banquet Tables + Chairs</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Market Lighting on the Back Lawn</v-list-item-content>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-content>Package Pricing for Cottage Rentals</v-list-item-content>
                    </v-list-item>
                </v-list>
            </v-col>
            <v-col md="4">
                <v-btn variant="outlined" to="/contact">
                    Start Planning
                </v-btn>
            </v-col>
        </v-row>
    </v-container>
  </template>
  
  <script lang="ts" setup>
  const text = `<hr class="w-25 mx-auto mb-2" />
            <span class="text-h3 d-block font-italic">Let's Celebrate</span>
            <hr class="w-25 mx-auto mt-2" />`
  </script>
  