<template>
    <v-app-bar 
      color="white"
      flat
      fixed
      :density="$vuetify.display.mobile ? 'comfortable' : 'prominent'"
      class="border-b-sm"
    >
      <template #append  v-if="$vuetify.display.mobile">
        <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
      </template>
      <template #prepend v-else>
        <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
      </template>
      <v-app-bar-title :class="{
        'text-center': !$vuetify.display.mobile
      }">
        <v-avatar :size="$vuetify.display.mobile ? 'x-large' : '125px'" :class="{
          'ml-n16': !$vuetify.display.mobile
        }">
          <v-img src="https://smitha-cdn.s3.us-east-2.amazonaws.com/BallHouse/ball-house-logo.png" />
        </v-avatar>
      </v-app-bar-title>
      <!-- <template #append>
        <v-btn href="tel:850-371-5472" icon>
          <v-icon>mdi-phone</v-icon>
        </v-btn> 
      </template> -->
    </v-app-bar>

    <v-navigation-drawer
        v-model="drawer"
        temporary
    >
      <v-list density="compact" nav>
        <v-list-item title="Home" value="home" to="/"></v-list-item>
        <v-list-item title="About" value="about" to="/about"></v-list-item>
        <!-- <v-list-item title="Stay" value="stay" to="/stay"></v-list-item> -->
        <v-list-item title="Meet, Celebrate & Pricing" value="pricing" to="/pricing"></v-list-item>
        <v-list-item title="Gallery" value="gallery" to="/gallery"></v-list-item>
        <v-list-item title="Contact" value="contact" to="/contact"></v-list-item>

        <!-- <v-list-item :subtitle="auth.signedIn ? auth.userDetails : 'Administration'"></v-list-item>
        <template v-if="auth.signedIn">
          <v-list-item prepend-icon="mdi-cards-outline" title="GCG Cards" href="/admin"></v-list-item>
          <v-list-item prepend-icon="mdi-nuke" title="Remove Personal Data" href="/.auth/purge/aad"></v-list-item>
          <v-list-item prepend-icon="mdi-logout" title="Sign out" href="/.auth/logout"></v-list-item>
        </template>
        <v-list-item v-else prepend-icon="mdi-login" title="Sign in" href="/.auth/login/aad"></v-list-item> -->
      </v-list>
    </v-navigation-drawer>
</template>

<script setup lang="ts">
import { ref, onMounted, watch } from 'vue'
import { useAppStore } from "@/store/app"
import { useAuthStore } from "@/store/auth"
import { useRoute } from 'vue-router'
const route = useRoute()

const store = useAppStore()
store.fetchContent()

const auth = useAuthStore()
auth.fetchAuth()

const drawer = ref(false)
const transparency = ref(false)

watch(route, (newVal) => {
    transparency.value = newVal.path === '/'
}, { immediate: true })

onMounted(() =>{
  window.addEventListener('scroll', () => {
    transparency.value = route.path === '/' && window.scrollY <= 75
  })
})
</script>
