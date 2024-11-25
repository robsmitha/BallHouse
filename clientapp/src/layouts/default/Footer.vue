<template>
    <v-sheet class="border-t-sm">
        <v-container fluid>
            <v-footer>
                <v-row>
                    <v-col md="8" cols="12">
                        <template v-for="i in icons" :key="i.href">
                            <v-btn
                                v-if="i.icon"
                                :href="i.href"
                                :icon="i.icon"
                                class="mx-3"
                                variant="plain"
                                target="_blank"
                            ></v-btn>
                            <v-btn v-else variant="plain" :href="i.href" target="_blank">
                                <v-avatar class="mx-3" size="x-small">
                                    <v-img :src="i.src"></v-img>
                                </v-avatar>
                            </v-btn>
                        </template>
                        
                    </v-col>
                    <v-col md="4" cols="12">
                        <div class="text-right text-caption font-weight-bold">
                            {{ new Date().getFullYear() }}  Ball House
                        </div>
                        <div class="text-right text-caption">
                            3255 Hemingway Blvd<br>Tallahassee, FL 32311, US
                        </div>
                    </v-col>
                </v-row>
            </v-footer>
        </v-container>
    </v-sheet>
</template>

<script setup lang="ts">
const icons = [
    {
        icon: 'mdi-pinterest',
        href: 'https://www.pinterest.com/ballhouseandcottagessouthwood'
    },
    {
        icon: 'mdi-instagram',
        href: 'https://www.instagram.com/ballhouseandcottages'
    },
    {
        icon: 'mdi-facebook',
        href: 'https://www.facebook.com/BallHouseandCottages'
    },
    {
        src: '//www.xoedge.com/myaccount/2012/grab-a-badge/social/flat/medium/round.png',
        href: 'http://www.theknot.com/marketplace/redirect-2009086?utm_source=vendor_website&utm_medium=banner&utm_term=6331a473-6c43-4d7b-9689-2803f5066291&utm_campaign=vendor_badge_assets'
    }
]
</script>