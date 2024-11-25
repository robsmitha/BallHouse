<template>
    <v-container fluid>
        <v-row>
            <v-col md="8">
                <v-card flat tile>
                    <v-card-title>
                        The Ball House
                    </v-card-title>
                    <v-card-text>
                        <span class="d-block mb-2">
                            Rich in history and originally built in 1865 the Ball House at SouthWood has been restored to resemble its original and elegant historical appearance.
                            Nestled among acres of rolling hills, majestic oaks, and native flowering trees, the charming manor provides a breathtaking backdrop for any event of any type.
                        </span>
                        <span class="d-block">
                            Whether it is a wedding, corporate party, holiday gathering, or social event, the Ball House at SouthWood is the perfect location to showcase any special occasion.
                            Looking to plan your next event? Contact us today!
                        </span>
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col md="4">
                <v-img
                    src="https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/history-bordered.jpg"
                    class="bg-grey-lighten-2"
                    cover
                    :aspect-ratio="16/9"
                >
                    <template v-slot:placeholder>
                        <v-row
                            align="center"
                            class="fill-height ma-0"
                            justify="center"
                        >
                            <v-progress-circular
                            color="grey-lighten-5"
                            indeterminate
                            ></v-progress-circular>
                        </v-row>
                    </template>
                </v-img>
            </v-col>
        </v-row>
        <v-row>
            <v-col md="4">
                <v-img
                    src="https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/cottages-bordered.jpg"
                    class="bg-grey-lighten-2"
                    cover
                    :aspect-ratio="16/9"
                >
                    <template v-slot:placeholder>
                        <v-row
                            align="center"
                            class="fill-height ma-0"
                            justify="center"
                        >
                            <v-progress-circular
                            color="grey-lighten-5"
                            indeterminate
                            ></v-progress-circular>
                        </v-row>
                    </template>
                </v-img>
            </v-col>
            <v-col md="8">
                <v-card flat tile>
                    <v-card-title>
                        The Cottages
                    </v-card-title>
                    <v-card-text>
                        <span class="d-block mb-2">
                            Quaint cottages tucked away amongst the serene and majestic oaks, the Ball House Cottages are the perfect setting for a peaceful getaway, romantic weekend, or accommodations for your guests.
                            Play a round of golf on the award-winning Fred Couples designed SouthWood Golf-Course while you stay in these home away from homes.
                        </span>
                        <span class="d-block">
                            A variety of amenities and packages are available to fit your needs.
                            We have five guests cottages on the grounds behind the Ball House.
                            Stay and Play packages and event pricing available upon request. Book your stay today!
                        </span>
                    </v-card-text>
                </v-card>
            </v-col>
        </v-row>
    </v-container>
  </template>
  
  <script lang="ts" setup>
  </script>
  