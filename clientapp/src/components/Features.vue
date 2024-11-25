<template>
    <v-sheet>
        <v-container fluid class="pa-0">
            <v-row no-gutters>
                <v-col v-for="f in features" cols="3" :key="f.url">
                    <v-img
                        :src="f.url"
                        aspect-ratio="1"
                        class="bg-grey-lighten-2"
                        cover
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
        </v-container>
    </v-sheet>
</template>

<script setup lang="ts">

const features = [
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ceremony-cropped.png'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/bridal-suite-cropped.png'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/details-cropped.png'
    },
    {
        url: 'https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/wedding-photo-cropped.png'
    }
]
</script>