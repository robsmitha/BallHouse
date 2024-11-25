<template>
    <HelloWorld 
        :text='
        `<hr class="w-25 mx-auto mb-2" />
            <span class="text-h3 d-block font-italic">Take a Look</span>
            <hr class="w-25 mx-auto mt-2" />`
        '
        src="https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/wedding-venue-gallery.jpg" 
        :height="350" 
    />
    <v-container fluid>
        <v-row class="text-center">
            <v-col md="4" offset="4">
                <v-divider class="w-25 mx-auto" />
                <span class="text-h4 my-2 d-block">Ball House</span>
                <v-divider class="w-25 mx-auto" />
            </v-col>
        </v-row>
        <v-row>
            <v-col v-for="f in ballHouse" cols="4" :key="f.url">
                <v-card flat tile class="h-100">
                    <v-img
                        :src="f.url"
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
                </v-card>
            </v-col>
        </v-row>
        <v-row class="text-center">
            <v-col md="4" offset="4">
                <v-divider class="w-25 mx-auto" />
                <span class="text-h4 my-2 d-block">Cottages</span>
                <v-divider class="w-25 mx-auto" />
            </v-col>
        </v-row>
        <v-row>
            <v-col v-for="f in cottages" cols="4" :key="f.url">
                <v-card flat tile class="h-100">
                    <v-img
                        :src="f.url"
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
                </v-card>
            </v-col>
        </v-row>
        <v-row class="text-center">
            <v-col md="4" offset="4">
                <v-divider class="w-25 mx-auto" />
                <span class="text-h4 my-2 d-block">Community</span>
                <v-divider class="w-25 mx-auto" />
            </v-col>
        </v-row>
        <v-row>
            <v-col v-for="f in community" cols="4" :key="f.url">
                <v-card flat tile class="h-100">
                    <v-img
                        :src="f.url"
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
                </v-card>
            </v-col>
        </v-row>
    </v-container>
  </template>
  
  <script lang="ts" setup>

  const ballHouse = [
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-1.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-2.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-3.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-4.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-5.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-6.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-7.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-8.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-9.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-10.jpg'
    }
]


const cottages = [
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/cottage-1.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/cottage-2.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/cottage-3.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/cottage-4.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/cottage-5.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/cottage-6.jpg'
    }
]


const community = [
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/community-1.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/community-2.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/community-3.jpg'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/community-4.jpg'
    }
]
  </script>
  