// Utilities
import { defineStore } from 'pinia'
import { WpPage, WpPost, WpTag, WpCategory } from './types'
import apiClient from '@/api/elysianClient'

type State = {
  pages: PageContent[]
}

type PageContent = {
  title: string,
  content: string,
  slug: string
}

export const useAppStore = defineStore('app', {
  state: (): State => ({
    pages: defaultState.pages
  }),
  getters: {
    // pages
    homePage: (state: State) => state.pages.find((page) => page.slug === 'ball-house-home-page') ?? defaultState.pages[0],
    makeReservationPage: (state: State) => state.pages.find((page) => page.slug === 'ball-house-make-reservation') ?? defaultState.pages[1],
    aboutPage: (state: State) => state.pages.find((page) => page.slug === 'ball-house-address-page') ?? defaultState.pages[2]
  },
  actions: {
    async fetchContent(): Promise<void> {
      // TODO: Deploy api
      return

      const response = await apiClient.getData('/api/WordPressContent')
      if (!response.success){
        console.error("Failed to get page content.")
        return
      }
      
      this.pages = response.data.pages.map((p : WpPage) => {
        return {
          title: p.title.rendered,
          content: p.content.rendered,
          slug: p.slug
        }
      })
    }
  }
})


const defaultState: State = {
  pages: [
    {
      content: '\n<p>Rich in history and originally built in 1865 the Ball House at SouthWood has been restored to resemble its original and elegant historical appearance.</p><br/><p>Nestled among acres of rolling hills, majestic oaks, and native flowering trees, the charming manor provides a breathtaking backdrop for any event of any type.</p>\n',
      title: 'Stay. Play. Celebrate.',
      slug: 'ball-house-home-page'
    },
    {
      content: '\n<p>Whether it is a wedding, corporate party, holiday gathering, or social event, the Ball House at SouthWood is the perfect location to showcase any special occasion. Looking to plan your next event? Contact us today!</p>\n',
      title: 'Make a Reservation',
      slug: 'ball-house-make-reservation'
    },
    {
      content: '\n<h4 class="wp-block-heading"><strong>Address</strong></h4>\n\n\n<div style="height:25px" aria-hidden="true" class="wp-block-spacer"></div>\n\n\n<p>3255 Hemingway Blvd<br>Tallahassee, FL 32311, US</p>',
      title: 'Address',
      slug: 'ball-house-address-page'
    }
  ]
};