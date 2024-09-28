import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import 'semantic-ui-css/semantic.min.css'
import 'dist/Calendar.css'
import 'dist/ReactToastify.min.css'
import './app/layout/styles.css'
import { StoreContext, store } from './app/stores/store'
import { RouterProvider } from 'react-router-dom'
import { router } from './app/router/Routes'

createRoot(document.getElementById('root')!).render(
    <StrictMode>
        <StoreContext.Provider value={store}>
            <RouterProvider router={router} />
        </StoreContext.Provider>
  </StrictMode>,
)
