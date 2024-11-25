<template>
  <v-sheet>
    <v-divider></v-divider>
    <v-container fluid class="pa-0">
      <v-row no-gutters>
        <v-col>
          <v-card class="text-center pb-2 border-e-sm" tile flat to="/gallery">
            <v-card-title class="text-overline d-block pb-0" style="color: #ba9e30;">See</v-card-title>
            <v-card-subtitle class="text-caption d-block">The Venue</v-card-subtitle>
          </v-card>
        </v-col>
        <v-col>
          <v-card class="text-center pb-2 border-e-sm" tile flat to="/pricing">
            <v-card-title class="text-overline d-block pb-0" style="color: #ba9e30">Plan</v-card-title>
            <v-card-subtitle class="text-caption d-block">Your Event</v-card-subtitle>
          </v-card>
        </v-col>
        <v-col>
          <v-card class="text-center pb-2 border-e-sm" tile flat to="/pricing">
            <v-card-title class="text-overline d-block pb-0" style="color: #ba9e30">Book</v-card-title>
            <v-card-subtitle class="text-caption d-block">Your Stay</v-card-subtitle>
          </v-card>
        </v-col>
        <v-col>
          <v-card class="text-center pb-2" tile flat to="/contact">
            <v-card-title class="text-overline d-block pb-0" style="color: #ba9e30">Connect</v-card-title>
            <v-card-subtitle class="text-caption d-block">With Us</v-card-subtitle>
          </v-card>
        </v-col>
      </v-row>
    </v-container>
    <v-divider></v-divider>
    <v-container>
      <v-row>
        <v-col md="8" cols="12">
          <template v-if="!homePage">
            <v-skeleton-loader
              type="article"
              color="transparent"
            ></v-skeleton-loader>
            <v-skeleton-loader
              v-for="i in 2"
              :key="i"
              type="paragraph"
              color="transparent"
            ></v-skeleton-loader>
          </template>
          <template v-else>
            <v-card color="transparent" flat>
              <v-card-title>Ball House and Cottages at Southwood</v-card-title>
              <v-card-subtitle>
                <span v-html="homePage.title"></span>
              </v-card-subtitle>
              <v-card-text>
                <span v-html="homePage.content"></span>
              </v-card-text>
              <!-- <v-card-actions>
                <v-btn to="/search" variant="tonal" :block="$vuetify.display.mobile">Make a Reservation</v-btn>
              </v-card-actions> -->
            </v-card>
          </template>
          <!-- <template v-if="!aboutPage">
            <v-skeleton-loader
              type="article"
              color="transparent"
            ></v-skeleton-loader>
            <v-skeleton-loader
              v-for="i in 2"
              :key="i"
              type="paragraph"
              color="transparent"
            ></v-skeleton-loader>
          </template>
          <template v-else>
            <v-card color="transparent" flat>
              <v-card-text>
                <span v-html="aboutPage.content"></span>
              </v-card-text>
            </v-card>
          </template> -->
        </v-col>
        <v-col md="4" cols="12"  class="justify-center align-center">
          <v-card flat tile class="h-100 mt-5">
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
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-sheet>
  <v-divider></v-divider>
</template>

<script setup lang="ts">
import { computed } from 'vue'
import { useAppStore } from "@/store/app";
import { storeToRefs } from 'pinia'

const emit = defineEmits(['search', 'clear'])
const appStore = useAppStore();
const { homePage, aboutPage } = storeToRefs(appStore)

</script>
