<template>
    <HelloWorld 
        :text="text"
        src="https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/celebrate-cropped.jpg" 
        :height="350" 
    />
    <v-container>
        <v-row>
            <v-col md="4" cols="12">
                <span class="text-h5 d-block">
                    Weddings
                </span>
                <span class="text-body-1 d-block">
                    We offer a comprehensive wedding package including our grand lawn ceremony and reception location.
                    Our package also includes:
                </span>
                <v-list density="compact">
                    <v-list-item>
                        <v-list-item-subtitle>Use of On-Site Bridal Suite</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Complimentary Parking</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Full Day Rental Block</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>White Chiavari Chairs for Ceremony</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Banquet Tables + Chairs for Reception</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Market Lighting on the Back Lawn</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Package Pricing for Cottage Rentals</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Feb-June and Oct-Dec $4999</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Jan and July-Sep $3999</v-list-item-subtitle>
                    </v-list-item>
                </v-list>
            </v-col>
            <v-col md="4" cols="12">
                <span class="text-h5 d-block">
                    Corporate & Social
                </span>
                <span class="text-body-1 d-block">
                    We offer a comprehensive rental package including our outdoor event space and the following:
                </span>
                <v-list density="compact">
                    <v-list-item>
                        <v-list-item-subtitle>Use of Manor</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Indoor and Outdoor Event Spaces</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Complimentary Parking</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Banquet Tables + Chairs</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Market Lighting on the Back Lawn</v-list-item-subtitle>
                    </v-list-item>
                    <v-list-item>
                        <v-list-item-subtitle>Package Pricing for Cottage Rentals</v-list-item-subtitle>
                    </v-list-item>
                </v-list>
            </v-col>
            <v-col md="4">
                <span class="text-h5 mb-3 d-block">
                    Start Planning
                </span>
                <v-btn variant="outlined" color="yellow-darken-2" :rounded="0" size="large" block to="/contact">
                    Contact Us
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
  