<template>
  <HelloWorld 
      :text='
      `<hr class="w-25 mx-auto mb-2" />
          <span class="text-h3 d-block font-italic">Get In Touch</span>
          <hr class="w-25 mx-auto mt-2" />`
      '
      src="https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/contact.jpg" 
      :height="350" 
  />
    <v-container>
      <v-row>
        <v-col md="8" offset-md="2">
          <span class="text-subtitle-1">
              Love What you see?
          </span>
          <br>
          <span class="text-subtitle-2">Let's get in touch!</span>
          <br>
          <br>
          <span class="text-body-1">
              Tell us more about your event or leave us comments on your stay!
              We would love to hear more.
          </span>
          </v-col>
      </v-row>
    </v-container>
  </template>
  
  <script lang="ts" setup>
  </script>
  